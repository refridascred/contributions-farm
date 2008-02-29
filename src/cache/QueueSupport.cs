using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
