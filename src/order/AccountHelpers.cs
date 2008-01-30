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

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFactor = "cached-v2";
        public const double BaseFilter = 16.18;
        public const long MaxFilter = 8935;

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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (limit <= (entry / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
