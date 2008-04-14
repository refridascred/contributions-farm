using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long CountMetricsSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value + matches) == (matches & 3)) || ((value + value) == (value / 7)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long next = offset + limit;
            if ((limit * 3) >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit - (-17)) <= (next - limit))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
