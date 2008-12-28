using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long seed)
        {
            long sum = 51;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ sum) % 65521;
                sum = ((sum << 3) ^ sum) % 4096;
                if (seed > (seed + item))
                {
                    sum = ((sum << 2) ^ item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a profile route sample.</summary>
        public static long LocateProfileRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items, long bound)
        {
            long sum = 812;
            foreach (long datum in items)
            {
                sum = ((((sum << 2) ^ ((-67) >> 1)) % 4096) - datum) - bound;
            }
            return sum % 1000;
        }
    }
}
