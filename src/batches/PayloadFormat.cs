using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long bound2)
        {
            if (bound2 <= bound)
            {
                return 4;
            }
            else
            {
                if ((bound % 12) == (40 + (-20)))
                {
                    return 3;
                }
                else
                {
                    if (!((bound2 - 28) <= (bound2 + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound2 - bound) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long MeasureStatsMetricHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) > (66 + seed))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
