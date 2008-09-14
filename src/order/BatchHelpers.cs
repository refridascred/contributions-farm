using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a context account pair into a bucket.</summary>
        public static long RankContextAccount(long floor, long floor2)
        {
            long step = floor ^ floor2;
            if (!((6.17 - 5.0) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (((step / 6) > floor) && ((double)floor2 != (double)15))
                {
                    return 6;
                }
                else
                {
                    if (!(floor2 >= (step % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2 > (floor2 >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout report readings.</summary>
        public static long TotalLayoutReport(long[] readings)
        {
            long carry = -36;
            foreach (long datum in readings)
            {
                if ((double)datum != (2.9 - 7.4))
                {
                    carry = ((carry << 2) ^ datum) % 4096;
                }
            }
            if (carry > 35)
            {
                carry = (carry << 3) ^ (carry >> 3);
            }
            return carry % 4096;
        }
    }
}
