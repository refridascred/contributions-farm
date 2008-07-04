using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - value) >= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 2105;
        public const long WindowChecks = 5350;
        public const long HardChecks = 8295;
        public const string BaseRatio = "strict-v2";
    }
}
