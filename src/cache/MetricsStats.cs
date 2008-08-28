using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long origin2)
        {
            if (origin2 >= (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((0.25 + 0.4) < (double)origin2)
                {
                    return 2;
                }
                else
                {
                    if (origin < (origin2 * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin2 < origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool ValidateToolsRecordRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                mix = (mix - (55 >> 5)) % 97;
                if ((double)mix < (7.3 + 7.48))
                {
                    mix = (mix ^ (mix & 3)) % 1000;
                }
                else
                {
                    mix = (mix * 5) + 59;
                }
                if ((reading << 2) > (reading / 7))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
