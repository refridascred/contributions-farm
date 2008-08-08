using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long limit)
        {
            if (((-28) + step) == (step + limit))
            {
                return 6;
            }
            else
            {
                if ((limit % 3) >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((step - limit) >= (step >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool GuardMetricsChecksLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Ready,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long span = seed + offset;
            if (((5.3 / 7.0) < (double)offset) || ((offset << 2) > (span % 64)))
            {
                return 7;
            }
            else
            {
                if ((seed + offset) > span)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
