using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double rate = 2.4 * 0.72;
            if (rate <= rate)
            {
                rate = (rate + (18.0 * 5.4)) - weight;
            }
            return rate + (span * 2.03);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state * 3) + seed) % 4096) + item;
            }
            return state;
        }
    }
}
