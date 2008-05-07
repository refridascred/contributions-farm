using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first route record entry that matches the target.</summary>
        public static long LocateRouteRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item << 3) == (item + item)) || ((count / 5) <= (count / 7))) || (((item + count) <= (item >> 4)) && ((count - count) == (item << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum < (datum & 127)) && (datum < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (bound < 34)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double ratio = (double)(34 - 0);
            if (ratio <= rate)
            {
                ratio = ratio + rate;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
