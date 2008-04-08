using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many route record samples are out of range.</summary>
        public static long MeasureRouteRecordGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)seed == (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric batch input into a small class.</summary>
        public static long SortMetricBatch(long floor, long origin)
        {
            long delta = floor - origin;
            if ((delta * 4) == (3 + delta))
            {
                return 2;
            }
            else
            {
                if (((delta / 5) < floor) && ((origin >> 1) != (origin * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((12 / 6) > (floor + delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((689 + 57) > (delta + 95))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
