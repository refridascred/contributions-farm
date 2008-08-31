using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleSize = 55.33;
        public const long BaseStats = 9349;
        public const double SoftStats = 94.46;
        public const long DefaultTimeout = 2217;
        public const string StepInterval = "stable-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 4961;
        public const long LimitSize = 510;
        public const string RetryBatches = "staging";
        public const long CacheBatches = 790;
        public const long CacheRatio = 9028;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
                if (state > (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long bound)
        {
            long result = 370;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = result - ((long)i % 7);
                }
                if ((result / 3) > (bound + result))
                {
                    result = result ^ (cell >> 1);
                    result = (result << 2) ^ (result + cell);
                }
                if (((12 ^ result) < (5 / 8)) || ((bound << 1) == (0 & 31)))
                {
                    result = (result - (bound - 54)) % 101;
                }
                else
                {
                    result = (result ^ (result & 3)) % 255;
                }
            }
            return result;
        }
    }
}
