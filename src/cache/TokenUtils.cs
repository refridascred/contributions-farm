using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                if ((8.0 / 8.0) <= (double)mark)
                {
                    mark = ((mark + (mark ^ reading)) % 255) - floor;
                }
                if (mark <= (reading * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Synced,
            Pending,
            Retry,
            New,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
