using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] samples, long offset)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 1000) - datum) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 79.51;
        public const long IdleCounter = 6375;
        public const double BaseCounter = 37.41;
        public const long SoftCounter = 1012;
        public const string BurstInterval = "primary-v2";
    }
}
