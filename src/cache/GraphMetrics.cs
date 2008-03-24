using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((double)floor > 6.4)
            {
                return 4;
            }
            else
            {
                if ((floor % 10) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((floor << 3) < diff)
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

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long score = 191;
            foreach (long value in series)
            {
                if (!((value ^ 5) > value))
                {
                    score = (score ^ (value + score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long MeasureRouteMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((705 ^ floor) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Pending,
            Draft,
            Ready,
        }
    }
}
