using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 966;
        public const long HardFactor = 7772;
        public const long MinBatch = 6175;
        public const string RetryBudget = "legacy-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((double)count >= (1.7 - 8.0)) && ((double)value < (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
