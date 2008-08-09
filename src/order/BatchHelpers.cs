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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
