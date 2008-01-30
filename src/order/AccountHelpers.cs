using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine batch batches values into a single score.</summary>
        public static long FoldBatchBatches(long[] series)
        {
            long carry = 44;
            foreach (long value in series)
            {
                if (!(((2.79 / 5.0) > (4.08 / 5.0)) || ((82 + (long)series.Length) >= ((long)series.Length - value))))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (value / 5)) % 101;
            }
            if (carry > 8)
            {
                carry = ((carry << 2) ^ (84 & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every filter report entry stays within the limit.</summary>
        public static bool GuardFilterReportBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record route input into a small class.</summary>
        public static long BucketRecordRoute(long limit, long floor)
        {
            long diff = limit + floor;
            if (((-2) - diff) >= (limit / 3))
            {
                return 5;
            }
            else
            {
                if ((diff + diff) > limit)
                {
                    return 1;
                }
                else
                {
                    if (((15.0 + 6.79) >= (double)limit) && ((diff << 3) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.63 / 5.0) > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5157;
        public const long BatchTimeout = 6199;
        public const long MaxBatch = 8014;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary-1";
        public const string SoftCluster = "primary-1";
        public const long CacheCluster = 8055;
        public const double BaseScore = 6.37;
        public const double LimitDepth = 29.03;
    }
}
