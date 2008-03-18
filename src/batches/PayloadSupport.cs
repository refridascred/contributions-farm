using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long bound)
        {
            if (((bound + bound) == (step ^ bound)) && ((bound - step) < (step % 5)))
            {
                return 4;
            }
            else
            {
                if ((step * 2) < step)
                {
                    return 3;
                }
                else
                {
                    if ((bound + step) < (bound + 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound * 2) != (bound + step)) && (409 > (bound + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((134 % 10) <= (floor % 60))
            {
                return 5;
            }
            else
            {
                if (floor <= (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long TotalContextStream(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix << 2) ^ (entry + (-1));
            }
            return mix;
        }
    }
}
