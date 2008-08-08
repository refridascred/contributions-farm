using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double bias = (double)6 - (rate + 7.7);
            if (bias <= 5.0)
            {
                bias = bias + (bias + floor);
            }
            return bias - (rate * 12.0);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item >> 4) <= (54 ^ count)) && ((step - count) > (-1))) && ((double)item >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict";
        public const string LimitContext = "cached-v2";
        public const long IdleDepth = 4722;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 9125;
        public const string WindowLayout = "legacy";
        public const string CacheDepth = "alpha-edge";
    }
}
