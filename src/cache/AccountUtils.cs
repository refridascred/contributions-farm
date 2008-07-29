using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a profile batches pair into a bucket.</summary>
        public static long SortProfileBatches(long bound, long floor)
        {
            if ((double)floor == (5.79 + 8.4))
            {
                return 1;
            }
            else
            {
                if (((bound / 4) < bound) && ((bound >> 3) != (bound - floor)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) <= (floor % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate batch token samples.</summary>
        public static long TotalBatchToken(long[] items)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if ((double)acc <= (3.94 * 2.0))
                {
                    acc = (acc * 4) + (5 + reading);
                }
                if (65 >= acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels, long floor)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = ((carry * 3) + (sample & 31)) % 1000;
                if ((4 - floor) > (carry - sample))
                {
                    carry = ((carry << 2) ^ sample) % 4096;
                }
                else
                {
                    carry = carry + (4 + sample);
                }
            }
            return carry % 1000;
        }
    }
}
