using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items, long seed)
        {
            long mix = 56;
            foreach (long entry in items)
            {
                if (((seed % 100) >= (seed + entry)) || ((mix - mix) < entry))
                {
                    mix = mix + ((long)items.Length >> 3);
                }
                else
                {
                    mix = ((mix << 3) ^ entry) % 97;
                }
            }
            if (mix > 34)
            {
                mix = (mix - (seed + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (1.0 * 7.0)) || ((6.63 / 8.0) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Active,
            Ready,
            Closed,
        }
    }
}
