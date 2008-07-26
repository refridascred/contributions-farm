using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            if (((seed + seed) < offset) || (offset >= (seed / 2)))
            {
                return 7;
            }
            else
            {
                if (offset >= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (1.0 - 3.2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset - seed) > seed) && ((seed + seed) >= (offset * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long CountAlreadyEditorMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + bound) <= (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
