using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((target & 63) < (target / 9))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long target)
        {
            long slot = seed - target;
            if ((4.46 - 19.0) != (double)slot)
            {
                return 0;
            }
            else
            {
                if (((seed - seed) != (slot & 63)) && ((seed + 22) == (376 ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if (6 < (target * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + target) >= slot)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
