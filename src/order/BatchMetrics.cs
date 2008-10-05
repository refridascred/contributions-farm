using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)origin == (16.0 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((prev ^ prev) >= (seed + prev))
                {
                    return 5;
                }
                else
                {
                    if ((origin + prev) < 1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long IdleQueue = 7111;
        public const long WindowQueue = 8974;
        public const double MinQueue = 15.82;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = result ^ (value % 2);
            }
            return result % 65521;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double weight = (floor + 2.3) + (rate / 3.0);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (5.09 + weight)) - (double)(long)i;
            }
            return weight + rate;
        }
    }
}
