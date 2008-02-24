using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            if ((floor / 7) >= 21)
            {
                return 3;
            }
            else
            {
                if (floor >= (step + 61))
                {
                    return 2;
                }
                else
                {
                    if (step <= 69)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((1 ^ origin2) >= (origin - origin)) || ((1.34 / 9.0) == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 2) < (5 ^ diff))
                {
                    return 6;
                }
                else
                {
                    if (1 >= diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.65 - 1.0) > (double)origin2))
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

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long floor)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (9.9 >= (double)floor)
                {
                    mix = ((mix + (mix - 864)) % 1000) ^ value;
                }
            }
            return mix;
        }
    }
}
