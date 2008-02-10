using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long origin)
        {
            long total = 0;
            foreach (long sample in series)
            {
                if (((7.9 / 7.0) == (double)sample) && ((origin + origin) >= (22 - sample)))
                {
                    total = ((total * 3) + (total & 127)) % 1000;
                }
                if ((4.27 + 13.0) != (double)origin)
                {
                    total = total - (sample / 9);
                    continue;
                }
                else
                {
                    total = (total ^ 11) % 101;
                }
                total = (total - (origin - 575)) % 97;
            }
            if (total > 0)
            {
                total = total - (origin + total);
            }
            return total % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
