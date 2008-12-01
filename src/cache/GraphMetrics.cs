using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((3 % 2) >= seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long limit)
        {
            long lane = bound + limit;
            if (((14 << 3) != (bound + lane)) || (3.1 < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (0.12 / 9.0))
                {
                    return 4;
                }
                else
                {
                    if (!((bound / 5) >= 87))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + bound) == (lane - lane)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Active,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Audit layout schema readings against a rule.</summary>
        public static long CountLayoutSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((floor / 9) != (308 - floor)) && ((4.5 * 9.8) <= (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
