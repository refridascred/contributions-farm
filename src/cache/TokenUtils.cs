using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 64.13;
        public const long MinFactor = 1552;
        public const string WindowScore = "cached-edge";
        public const string IdleCache = "staging-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 98.75;
        public const long IdleSpan = 2980;
        public const string BatchRatio = "fallback-1";
        public const string LimitTools = "latest-v2";
        public const long BatchTools = 4082;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((sample - tally) >= (sample - (-720))) && (tally < (sample / 3))) || ((double)sample < 4.3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
