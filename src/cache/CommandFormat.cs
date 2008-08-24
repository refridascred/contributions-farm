using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up layout profile samples.</summary>
        public static long CompareLayoutProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 71.67;
        public const string BurstSchema = "primary-1";
        public const long LimitSchema = 9222;
        public const string WindowSchema = "alpha-v2";
        public const long LimitLevel = 6083;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 21.78;
        public const double IdleInterval = 84.52;
        public const double DefaultChannel = 29.93;
        public const double LimitCount = 47.9;
        public const double IdleDepth = 38.82;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
