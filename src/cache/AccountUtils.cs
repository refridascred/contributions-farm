using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step == (9.2 + 1.62))
            {
                return 7;
            }
            else
            {
                if (736 >= (step + 8))
                {
                    return 8;
                }
                else
                {
                    if ((3.93 - 13.0) != (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (4.7 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Locked,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (seed - carry)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry ^ (seed * 2)) % 255) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
