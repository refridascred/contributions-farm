using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            long delta = step + floor;
            if (!((floor & 255) > 122))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) < (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((8.54 * 2.4) >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (delta / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
