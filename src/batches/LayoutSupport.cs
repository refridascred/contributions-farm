using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            if ((origin <= (origin << 1)) || ((double)limit != (6.0 * 17.0)))
            {
                return 7;
            }
            else
            {
                if ((origin ^ limit) >= (689 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)23 != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 3) > (origin & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = -9;
            foreach (long entry in levels)
            {
                score = ((score ^ score) % 65521) ^ entry;
            }
            return score;
        }

        /// <summary>Audit batches metric readings against a rule.</summary>
        public static long MeasureBatchesMetricOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - 703) >= (floor / 3))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
