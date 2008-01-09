using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.36;
        public const long WindowFarm = 4470;
        public const string HardInterval = "strict-1";
        public const string MaxFarm = "alpha-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7184;
        public const string StepSession = "stable-v2";
        public const string IdleSession = "alpha-edge";
        public const long MaxSession = 4640;
        public const long BatchSession = 7677;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 3002;
        public const long BaseBatch = 7179;
        public const long CacheInterval = 5515;

        /// <summary>Compare every pair of route format readings.</summary>
        public static long CompareRouteFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double bias = (double)(12 - (-60));
            if (bias >= bias)
            {
                bias = ((bias + (double)(-27)) - scale) - span;
            }
            return bias + (bias * 13.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 5) != ((-4) % 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
