using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long MeasureAlreadyProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen > (741 & 63))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4471;
        public const long IdleBatches = 8951;
        public const double SoftBatches = 73.39;
        public const long MaxBatches = 8397;
        public const string BatchBatches = "primary-v2";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultDepth = "open-v2";
        public const long BatchTimeout = 462;
        public const long BatchBuffer = 1601;
        public const string MaxBuffer = "primary-v2";
    }
}
