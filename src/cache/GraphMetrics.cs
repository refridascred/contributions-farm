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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ bound) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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
