using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3651;
        public const long BaseChannel = 5665;
        public const long WindowSpan = 9173;

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long CountCommitsSupportOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (item & 255))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3260;
        public const double WindowLevel = 89.97;
        public const long BatchMetrics = 6742;
        public const string DefaultMetrics = "primary-v2";
    }
}
