using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Dropped,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardFactor = "latest";
        public const long BurstRoute = 5331;
        public const long IdleRoute = 468;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                sum = (sum - (value & 7)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long seed)
        {
            long result = -40;
            foreach (long sample in data)
            {
                if (!((seed * 5) >= (sample + seed)))
                {
                    result = ((result << 2) ^ 219) % 255;
                }
                result = result - ((-705) + 5);
            }
            if (result < 235)
            {
                result = (result ^ (519 ^ seed)) % 4096;
            }
            return result;
        }
    }
}
