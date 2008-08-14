using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 270;
            foreach (long value in readings)
            {
                carry = (carry << 3) ^ (carry & 1);
                if ((9.8 * 6.72) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (82 + value)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (value >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 54.08;
        public const double WindowBudget = 68.19;
        public const long WindowSize = 3288;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long limit2)
        {
            if ((double)limit2 < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit2 > (973 % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 3) < (cell << 3))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool CheckStreamBatchesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
