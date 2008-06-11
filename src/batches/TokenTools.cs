using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (!(item <= acc))
                {
                    acc = ((acc << 2) ^ (acc / 8)) % 4096;
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((double)floor <= (9.7 / 3.0))
            {
                return 6;
            }
            else
            {
                if (floor > (967 - 540))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 5) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
