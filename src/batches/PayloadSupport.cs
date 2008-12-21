using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftTimeout = 85.15;
        public const long MinWidth = 2326;
        public const double DefaultBatches = 41.76;
        public const long RetryBatches = 9955;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long seed)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = ((total << 2) ^ (seed + seed)) % 255;
                if ((total >> 1) <= (datum - datum))
                {
                    total = (total << 3) ^ (total + 92);
                }
                else
                {
                    total = (total ^ (datum - seed)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
