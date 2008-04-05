using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Dropped,
            Active,
            Closed,
            Done,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                if ((44 * 2) >= (reading * 3))
                {
                    mix = ((mix << 3) ^ (reading + 68)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ reading;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
