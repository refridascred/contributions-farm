using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(hits > (seed ^ reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long step)
        {
            if (((step + step) >= (883 + 223)) || ((limit & 255) > step))
            {
                return 7;
            }
            else
            {
                if ((limit + 1) >= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((step * 2) <= (step - 6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
