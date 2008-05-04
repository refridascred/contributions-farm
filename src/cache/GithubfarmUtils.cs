using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long step)
        {
            if (660 <= offset)
            {
                return 5;
            }
            else
            {
                if ((step << 2) < 0)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long TallyFilterBatches(long[] data, long floor)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (carry > (floor - carry))
                {
                    carry = ((carry - (floor & 1)) % 1000) ^ cell;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
            }
            if (carry < 51)
            {
                carry = (carry ^ (long)data.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long seed)
        {
            if (!((double)limit <= 1.4))
            {
                return 7;
            }
            else
            {
                if (limit >= 965)
                {
                    return 4;
                }
                else
                {
                    if ((0.03 - 6.34) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 100) == (3 - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long bound)
        {
            long result = 8;
            foreach (long item in levels)
            {
                result = result ^ bound;
                result = (result << 2) ^ item;
            }
            return result;
        }
    }
}
