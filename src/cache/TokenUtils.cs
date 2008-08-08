using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long TallyPayloadMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value ^ value) > (value + matches)) || ((value & 15) != (matches - value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 4363;
        public const string IdleChecks = "latest-1";
        public const long StepBudget = 6064;
        public const double WindowScore = 78.92;
    }
}
