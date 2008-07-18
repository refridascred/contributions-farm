using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 68.4;
        public const long CacheTimeout = 6624;
        public const string IdleRoute = "latest";
        public const long BatchTimeout = 1603;
        public const long CacheBudget = 6213;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 646;
        public const string MinChecks = "local-v2";
        public const long IdleChecks = 7949;
        public const string MinBudget = "open";

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 65.07;
        public const string DefaultDepth = "stable-1";
        public const long BatchStream = 9557;
        public const long BaseStream = 4712;
        public const long BatchFactor = 928;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9508;
        public const long RetryStream = 9235;
        public const long StepStream = 2136;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
