using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin == (8.9 + 0.9)) && (origin < mix))
                {
                    mix = (mix + origin) % 97;
                    continue;
                }
                mix = (mix ^ origin) % 4096;
                if (150 < (origin + mix))
                {
                    mix = (mix - (origin + origin)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((span <= (span + origin)) && ((origin % 24) <= (floor >> 2)))
            {
                return 4;
            }
            else
            {
                if ((544 + span) > 8)
                {
                    return 5;
                }
                else
                {
                    if (((origin / 4) < (5 - floor)) || (6.89 < 12.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
