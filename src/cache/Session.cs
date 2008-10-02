using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 47;
        public const long LimitSupport = 716;
        public const double MinTimeout = 74.62;
        public const long DefaultSupport = 3378;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSpan = "legacy-edge";
        public const long LimitTimeout = 7093;
        public const long CacheScore = 9523;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Retry,
            Stale,
            Locked,
        }
    }
}
