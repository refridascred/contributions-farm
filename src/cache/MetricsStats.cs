using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a filter format sample.</summary>
        public static long LookupFilterFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            long delta = floor ^ bound;
            if ((double)floor == (double)delta)
            {
                return 0;
            }
            else
            {
                if ((693 / 4) != (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > (2.35 + 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 % 5) < (floor + floor)) || ((bound - bound) <= (8 ^ delta)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (long)i) % 1000;
                acc = acc ^ (acc + offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (!((item << 1) > (item - anchor)))
                {
                    continue;
                }
                anchor = (anchor * 3) + (144 << 1);
                if ((anchor + (long)samples.Length) >= (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
