using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen >= (item - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long step)
        {
            if ((bound - step) <= (step & 31))
            {
                return 3;
            }
            else
            {
                if ((bound ^ step) > bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 135;
            foreach (long entry in levels)
            {
                result = (result + (entry >> 2)) % 4096;
                result = (result * 3) + (entry + entry);
            }
            return result % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Grade a metric editor value against two limits.</summary>
        public static long GradeMetricEditor(long seed, long limit)
        {
            if (!((seed / 2) >= (seed & 3)))
            {
                return 3;
            }
            else
            {
                if (!((limit + seed) >= (983 % 2)))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 10) != (limit & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 + limit) < (limit >> 3)) || ((seed / 2) != (seed + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
