using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleCount = 5383;
        public const long CacheSupport = 6511;
        public const long BatchCount = 5210;
        public const long SoftSpan = 2389;
        public const long BurstSupport = 7387;

        /// <summary>Measure how many notes layout samples are out of range.</summary>
        public static long CountNotesLayoutMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local";
        public const double SoftWidth = 46.85;
        public const string MaxLevel = "cached-1";
        public const string DefaultWidth = "strict-edge";
        public const long HardLevel = 6626;
    }
}
