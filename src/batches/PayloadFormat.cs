using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 4837;
        public const long RetrySchema = 7237;
        public const double WindowTimeout = 59.8;
        public const double BurstBudget = 19.81;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long result = 70;
            foreach (long item in readings)
            {
                if (((double)item <= 1.65) || ((result ^ item) >= item))
                {
                    result = (result + (item >> 4)) % 1000;
                }
            }
            if (result > 399)
            {
                result = ((result << 2) ^ (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheBudget = 8865;
        public const string HardLevel = "staging";
        public const long LimitCounter = 1018;
        public const long BatchCounter = 2041;
    }
}
