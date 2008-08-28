using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first stats token entry that matches the target.</summary>
        public static long LocateStatsTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 28.43;
        public const double MinWidth = 34.75;
        public const long StepRoute = 6180;
        public const double BaseRoute = 35.43;

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long RollLayoutBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((offset & 63) < (state - state)) || ((state - 0) < (offset - (long)i)))
                {
                    state = (state + (offset / 4)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 7479;
        public const double RetryRatio = 85.78;
        public const double CacheSpan = 45.18;
        public const long DefaultSpan = 1311;
        public const string StepInterval = "local-v2";
    }
}
