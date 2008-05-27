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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                long diff = ((long)i / 6) & 3;
                if ((double)diff != (double)target)
                {
                    diff = diff - (160 ^ (long)i);
                }
                else
                {
                    acc = acc + ((long)i << 2);
                    acc = (acc << 2) ^ (target & 31);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
