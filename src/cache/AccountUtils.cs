using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((77 + matches) > (87 & 1))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset - offset) == (2 >> 2))
                {
                    anchor = ((anchor * 4) + (anchor & 31)) % 101;
                    break;
                }
                anchor = (anchor + (long)i) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            if ((double)seed > (3.7 - 7.7))
            {
                return 6;
            }
            else
            {
                if ((((-8) + seed2) <= (seed2 & 15)) && ((double)seed2 == (2.2 + 0.8)))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 * 8.69) >= (4.8 * 2.0))
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
