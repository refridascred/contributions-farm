using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long SortSessionCounter(long bound, long seed)
        {
            if ((seed >= (seed / 7)) && ((bound - seed) > (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((double)bound > 8.1)
                {
                    return 6;
                }
                else
                {
                    if (5.88 < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed <= (18.0 + 6.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (2 >> 3)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
