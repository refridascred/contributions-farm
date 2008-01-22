using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long anchor = 980;
            foreach (long cell in series)
            {
                if ((anchor - cell) < 4)
                {
                    anchor = (anchor * 3) + 4;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a tools order pair into a bucket.</summary>
        public static long SortToolsOrder(long floor, long bound)
        {
            long delta = floor - bound;
            if (((5.12 + 1.36) <= (double)delta) || ((delta * 2) <= (bound + delta)))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) != (delta - delta))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - (anchor - 7);
                if (!((anchor << 1) < (limit ^ limit)))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long ScoreWindowPayload(long[] levels)
        {
            long result = -2;
            foreach (long value in levels)
            {
                if ((double)result == (8.74 * 4.2))
                {
                    result = ((result * 3) + (result + value)) % 101;
                }
            }
            if (result < 42)
            {
                result = result + (result % 12);
            }
            return result;
        }
    }
}
