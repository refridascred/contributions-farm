using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long score = 265;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ (score << 2)) % 97) - datum;
            }
            if (score > 13)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheRatio = 37.92;
        public const long DefaultGithubfarm = 4724;
        public const double SoftGithubfarm = 56.86;
        public const string BaseGithubfarm = "primary-1";
        public const string MaxGithubfarm = "legacy-edge";
    }
}
