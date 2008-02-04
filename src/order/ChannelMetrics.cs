using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate layout batch readings against a bound.</summary>
        public static bool GuardLayoutBatchRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a context farm pair into a bucket.</summary>
        public static long ClassifyContextFarm(long offset, long seed)
        {
            if ((offset >> 2) < seed)
            {
                return 2;
            }
            else
            {
                if (((seed & 31) != (offset * 3)) || ((76 - offset) != ((-7) & 255)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metrics window samples are out of range.</summary>
        public static long CountMetricsWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches > (95 + (long)values.Length)) && ((datum + datum) >= (matches / 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
