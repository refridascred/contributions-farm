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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((17.0 / 9.0) == (double)floor)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}
