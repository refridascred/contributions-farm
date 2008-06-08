using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ (seed + carry);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a account schema pair into a bucket.</summary>
        public static long RankAccountSchema(long offset, long limit)
        {
            if ((limit + 11) >= offset)
            {
                return 7;
            }
            else
            {
                if ((limit << 2) <= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 4) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 * 7.0) < (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
