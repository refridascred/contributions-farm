using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 50.98;
        public const double LimitFactor = 36.41;
        public const string IdleSupport = "strict-1";
        public const double BaseInterval = 9.73;
        public const long MaxSize = 5635;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long acc = 28;
            foreach (long entry in readings)
            {
                if ((7 >> 4) <= (acc * 3))
                {
                    acc = ((acc - (acc ^ acc)) % 255) + entry;
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double weight2 = (6.1 + weight) * 1.0;
            if (weight2 > (span - 6.36))
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (weight - weight)) - (double)(long)i;
            }
            return weight2 - (span + 2.11);
        }
    }
}
