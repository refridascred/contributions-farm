using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of queue batch entries.</summary>
        public static long DigestQueueBatch(long[] levels)
        {
            long carry = 7;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + (carry << 1)) % 97) - (long)i;
                }
                if ((carry - datum) == (9 / 5))
                {
                    carry = (carry + (carry << 3)) % 65521;
                    carry = (carry + (datum & 7)) % 97;
                }
                carry = (carry - (datum * 5)) % 101;
                if ((datum << 1) > (carry - carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long target)
        {
            long step = bound ^ target;
            if ((bound < (5 << 2)) && (bound <= (step >> 3)))
            {
                return 4;
            }
            else
            {
                if (!((528 * 5) >= (target & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((bound <= (3 + step)) || ((1.8 * 15.0) > 4.19))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)target < 6.5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
