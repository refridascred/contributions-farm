using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long target)
        {
            long lane = offset + target;
            if ((lane >= (target / 9)) || ((double)lane <= (3.9 - 20.0)))
            {
                return 4;
            }
            else
            {
                if (!((-13) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((25 + acc) != (datum & 127))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 92)
            {
                acc = acc ^ ((long)data.Length ^ acc);
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((seed - cur) != (cur ^ 9))
            {
                return 4;
            }
            else
            {
                if (((cur / 2) < seed2) && ((seed % 8) > (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if (cur <= 514)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((87 + 96) != (seed - seed2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
