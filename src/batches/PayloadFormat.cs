using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first schema batch entry that matches the target.</summary>
        public static long FindSchemaBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((step * 5) > (hits % 100))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long prev = seed + offset;
            if (((15.0 * 11.0) < (double)offset) || ((offset % 16) <= seed))
            {
                return 0;
            }
            else
            {
                if (((seed ^ offset) >= prev) && (prev >= (prev << 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset ^ prev) < seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
