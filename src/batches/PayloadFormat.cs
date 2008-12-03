using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry - entry) < (matches >> 5)) || ((matches << 2) == (entry - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxTimeout = "primary-edge";
        public const string DefaultBatch = "strict";
        public const string HardFactor = "fallback";
        public const long MaxRatio = 4236;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
