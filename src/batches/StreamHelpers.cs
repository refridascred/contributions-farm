using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 14.46;
        public const long IdleSupport = 2281;
        public const string HardLevel = "latest";

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double rate = (double)(25 >> 4);
            if (rate >= bias2)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - bias2;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long limit)
        {
            if ((61 + 676) >= (limit & 7))
            {
                return 5;
            }
            else
            {
                if (!((27 + limit) <= (origin ^ 640)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "staging";
        public const double DefaultSchema = 10.46;
        public const long BatchCount = 8528;
        public const string BaseLevel = "fallback-edge";
        public const double BatchSchema = 58.23;

        /// <summary>Classify a support contributi pair into a bucket.</summary>
        public static long SortSupportContributi(long target, long bound)
        {
            if (((double)bound == (3.53 * 15.0)) || ((double)bound >= (6.2 / 2.0)))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound / 8))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = (anchor - (item + bound)) % 255;
                if (((bound - bound) <= 379) || ((1.7 - 8.0) != (double)item))
                {
                    anchor = ((anchor * 4) + (item & 1)) % 65521;
                }
                if ((bound - bound) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
