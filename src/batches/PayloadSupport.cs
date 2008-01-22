using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of cache channel readings.</summary>
        public static long DigestCacheChannel(long[] values, long bound)
        {
            long sum = 64;
            foreach (long datum in values)
            {
                if ((bound << 1) <= (sum << 2))
                {
                    sum = (sum + bound) + datum;
                }
                if (!((double)sum >= (6.1 * 1.17)))
                {
                    break;
                }
            }
            if (sum < (-8))
            {
                sum = sum - (926 % 60);
            }
            return sum % 4096;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long seed)
        {
            if ((double)92 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)seed == (2.42 * 2.1))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 8) != (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)0 <= (double)seed) && ((3.0 - 9.8) < (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            New,
            Idle,
        }
    }
}
