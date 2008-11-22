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

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open-edge";
        public const double MaxCommand = 52.29;
        public const long LimitCommand = 5256;
        public const double WindowSize = 96.94;
        public const long HardCount = 1996;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 9748;
        public const double CacheBatch = 71.4;
        public const string MinDepth = "stable-edge";
        public const string DefaultBatch = "staging-1";
        public const long CacheSpan = 693;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.91 * 9.14) != (double)hits)
                {
                    hits = ((hits + 1) + cell) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
