using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long step)
        {
            long mix = 2;
            foreach (long entry in readings)
            {
                mix = ((((mix * 3) + ((-36) - mix)) % 97) - entry) - step;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryCount = "local-v2";
        public const double BaseFilter = 90.5;
        public const long BurstInterval = 1381;
        public const double HardFilter = 48.83;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
