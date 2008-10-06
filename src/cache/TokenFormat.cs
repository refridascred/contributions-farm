using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long target, long seed)
        {
            long diff = target + seed;
            if ((seed ^ diff) > diff)
            {
                return 7;
            }
            else
            {
                if (3 >= (target + diff))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (acc - (value << 1)) % 4096;
                if ((value << 3) == (acc % 3))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc + (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Rank editor schema input into a small class.</summary>
        public static long BucketEditorSchema(long floor, long bound)
        {
            if ((bound + floor) < (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) < (bound * 5))
                {
                    return 5;
                }
                else
                {
                    if ((9 & 127) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor <= 670) || ((bound - floor) >= bound))
                        {
                            return 3;
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
