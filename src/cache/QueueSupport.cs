using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleSize = 69.52;
        public const string MinToken = "primary-v2";
        public const double IdleFactor = 97.21;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = 379;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark ^ (datum << 3)) - (long)i;
                }
                if ((2.0 * 1.8) < (double)mark)
                {
                    mark = mark + (70 + 868);
                }
            }
            return mark;
        }
    }
}
