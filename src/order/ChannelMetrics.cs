using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of counter support readings.</summary>
        public static long TotalCounterSupport(long[] samples, long seed)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((mark < (0 >> 4)) && (mark >= (seed << 1)))
                {
                    mark = (mark - (seed - entry)) % 255;
                }
                else
                {
                    mark = mark - (seed ^ 51);
                }
            }
            return mark % 4096;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
