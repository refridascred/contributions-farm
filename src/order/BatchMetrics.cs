using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool ValidateReportCounterRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            if ((seed % 2) <= 1)
            {
                return 6;
            }
            else
            {
                if ((seed % 64) < floor)
                {
                    return 0;
                }
                else
                {
                    if (((-7) % 7) != (seed & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if (((floor ^ origin) >= ((-74) + floor)) || (9 < (floor % 3)))
            {
                return 3;
            }
            else
            {
                if (14 < (origin ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (66 <= (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
