using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 47.67;
        public const long BaseAlready = 4846;
        public const long SoftAlready = 1475;
        public const long WindowRatio = 7022;
        public const string IdleAlready = "strict-edge";

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long MeasureBatchesCommitsMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell % 100) >= (cell * 3))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 9748;
        public const double CacheBatch = 71.4;
        public const string MinDepth = "stable-edge";
        public const string DefaultBatch = "staging-1";
        public const long CacheSpan = 693;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 7923;
        public const string BurstFarm = "legacy-v2";
        public const long BurstRatio = 6150;
        public const long BatchDepth = 8632;
    }
}
