using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4916;
        public const string SoftSize = "alpha";
        public const double DefaultInterval = 90.46;
        public const long BurstMetrics = 4517;
        public const string BatchSpan = "stable";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + entry) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
