using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank tools channel input into a small class.</summary>
        public static long RankToolsChannel(long origin, long seed)
        {
            long lane = origin - seed;
            if ((seed + origin) <= (origin * 4))
            {
                return 2;
            }
            else
            {
                if ((seed & 31) == (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((6 ^ lane) != (seed & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)12)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
