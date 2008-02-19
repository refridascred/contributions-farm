using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 41;
            foreach (long item in readings)
            {
                if (!((8.0 + 0.26) > (double)state))
                {
                    state = (state ^ (item << 1)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 1)
            {
                state = (state << 2) ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double rate2 = span + (rate + 20.0);
            return rate2 + rate;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Queued,
        }
    }
}
