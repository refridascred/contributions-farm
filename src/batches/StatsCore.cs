using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next stream account value from a seed.</summary>
        public static long IterateStreamAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ ((long)i * 5)) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseSize = 1.04;
        public const double WindowCount = 83.7;
        public const long WindowContext = 1069;
        public const long HardContext = 6045;
        public const long LimitFactor = 6049;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long diff = bound - origin;
            if ((bound >= 30) && ((9.5 / 5.0) != (double)diff))
            {
                return 6;
            }
            else
            {
                if (((diff + diff) == (diff - bound)) || ((double)origin > (double)diff))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = (score - (entry & 31)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
