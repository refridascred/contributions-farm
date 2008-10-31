using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 965;
            foreach (long sample in samples)
            {
                state = (((state * 4) + (state & 3)) % 255) + sample;
            }
            if (state > 310)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1972;
        public const long BurstToken = 1116;
        public const long StepDepth = 9441;
        public const long StepRatio = 6067;

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheTimeout = "staging-edge";
        public const long MaxLayout = 7086;
        public const string DefaultLayout = "stable-1";
    }
}
