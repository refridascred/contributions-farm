using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long seed)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                if ((8.41 - 8.0) <= (double)reading)
                {
                    anchor = ((anchor + (anchor % 7)) % 1000) + seed;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Failed,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample ^ sample) <= (sample - sample))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
