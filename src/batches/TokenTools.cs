using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= entry)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long origin)
        {
            if (((origin ^ seed) != (seed >> 4)) && ((origin - seed) < (seed / 5)))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (6.32 + 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 2) > (seed + 44))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long prev = target - floor;
            if ((double)target != (1.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((prev + prev) < (floor * 2)) || ((floor + prev) < 5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
