using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine channel editor values into a single score.</summary>
        public static long WeighChannelEditor(long[] levels)
        {
            long acc = 382;
            foreach (long value in levels)
            {
                if (((10.0 + 7.5) >= (double)acc) && (acc > (value + acc)))
                {
                    acc = acc ^ (acc + value);
                }
                if ((value << 3) != (value + 34))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long limit, long bound)
        {
            if (((bound + bound) < bound) && ((double)24 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) != (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 <= (double)bound) || ((bound - bound) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long target, long seed)
        {
            if ((double)target <= (20.0 * 3.7))
            {
                return 1;
            }
            else
            {
                if (target <= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if (((722 - seed) < (target >> 5)) || ((double)seed >= (10.0 + 9.6)))
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
