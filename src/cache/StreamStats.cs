using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] data)
        {
            long total = 19;
            foreach (long value in data)
            {
                if (!((10.0 / 2.0) != (double)value))
                {
                    total = total + (total << 1);
                }
                if (!((value + value) >= value))
                {
                    total = (total + value) % 255;
                }
                if (total < (value + total))
                {
                    total = total - ((-373) * 5);
                }
            }
            return total % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 84.63;
        public const long MaxBudget = 8806;
        public const double MaxCount = 68.39;
        public const long SoftTimeout = 8657;
        public const double StepCount = 44.59;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxWidth = 45.95;
        public const string DefaultSpan = "strict-v2";
        public const long BatchEntry = 2815;
        public const long BurstBudget = 5641;
    }
}
