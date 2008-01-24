using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            long cur = step - target;
            if (((4.3 / 7.0) <= (double)step) || ((3.2 + 4.54) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((cur - step) == (target / 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            if ((floor + floor) != (bound % 10))
            {
                return 2;
            }
            else
            {
                if (((bound ^ 77) != (floor ^ floor)) || ((double)floor < (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (19 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < (floor % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
