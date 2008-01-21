using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long step)
        {
            long state = 76;
            foreach (long datum in data)
            {
                if (((5 - state) < state) || (datum <= (step % 64)))
                {
                    state = (state * 3) + (step + datum);
                }
            }
            if (state < 45)
            {
                state = (state ^ step) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long bound)
        {
            if (((double)origin >= (3.92 + 9.69)) || ((bound + bound) >= origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin <= (6.0 - 4.52)) && ((bound * 3) < origin))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) != (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
