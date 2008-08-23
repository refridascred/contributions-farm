using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (seen % 2))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long acc = 89;
            foreach (long cell in items)
            {
                acc = (((acc ^ (0 * 2)) % 255) - cell) - origin;
            }
            if (acc < 0)
            {
                acc = acc ^ 133;
            }
            return acc;
        }
    }
}
