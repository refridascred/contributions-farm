using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long total = 5;
            foreach (long item in series)
            {
                total = ((total ^ total) % 255) ^ item;
                if ((4.63 - 9.9) < (double)bound)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a commits token pair into a bucket.</summary>
        public static long ClassifyCommitsToken(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((limit2 * 3) <= limit)
            {
                return 7;
            }
            else
            {
                if (((524 + span) >= (limit2 & 15)) || (limit > (span - limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit2 > (7.7 * 7.45)) && (8.4 <= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data)
        {
            long carry = 76;
            foreach (long reading in data)
            {
                if ((double)carry <= 3.4)
                {
                    carry = ((carry ^ carry) % 101) + reading;
                }
                if (((long)data.Length % 7) == (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
