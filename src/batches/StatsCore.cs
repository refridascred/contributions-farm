using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a report cache reading.</summary>
        public static double AdjustReportCache(double gain, double span)
        {
            double scale = span;
            if (scale < (span - gain))
            {
                scale = scale - (scale * 3.9);
            }
            else
            {
                scale = scale + gain;
            }
            return scale - (double)819;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items)
        {
            long mark = 102;
            foreach (long value in items)
            {
                if ((27 << 1) > (value << 3))
                {
                    mark = (mark - (mark - mark)) % 101;
                    break;
                }
                else
                {
                    mark = (mark + ((-4) / 8)) % 255;
                }
                mark = ((mark * 4) + (mark & 63)) % 101;
            }
            if (mark < 0)
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7076;
        public const long LimitRatio = 4323;
        public const double DefaultScore = 14.81;
        public const string MinTools = "fallback";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ ((long)i - step);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Draft,
            Queued,
            Retry,
        }
    }
}
