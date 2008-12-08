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

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetrySpan = "primary-1";
        public const long BurstDepth = 1433;
        public const long IdleQueue = 1205;
        public const long BurstFactor = 3667;

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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
