using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value <= (2.57 - 5.84))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long ClassifySchemaBatches(long limit, long limit2)
        {
            if (limit2 >= (limit2 % 100))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) != (limit - (-43)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (812 ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit >= (13.0 - 9.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
