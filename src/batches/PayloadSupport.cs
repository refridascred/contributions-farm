using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batch stats values into a single score.</summary>
        public static long WeighBatchStats(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((sum >= (sum & 1)) && ((3 - cell) <= (cell - cell)))
                {
                    sum = sum + (sum % 24);
                }
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first cluster channel entry that matches the target.</summary>
        public static long LocateClusterChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
