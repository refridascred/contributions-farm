using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long anchor = 365;
            foreach (long reading in series)
            {
                anchor = (anchor + (anchor - 3)) % 1000;
                if (((-7) ^ anchor) <= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
