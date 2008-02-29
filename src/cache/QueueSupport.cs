using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = state - (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if (((8.76 * 1.0) > (double)bound) || (bound < 407))
            {
                return 7;
            }
            else
            {
                if ((3.03 / 5.0) >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 87) != (seed & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 64) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + value) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
