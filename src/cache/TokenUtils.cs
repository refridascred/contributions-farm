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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 7896;
        public const long LimitSchema = 9723;
        public const long HardCount = 7049;
        public const long MinRatio = 7090;
        public const long WindowInterval = 1348;
    }
}
