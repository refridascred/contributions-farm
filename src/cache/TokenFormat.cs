using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long state = -94;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (1 * 4)) % 101;
                state = (state << 3) ^ (9 ^ state);
                state = (state + reading) % 101;
                if (reading < (419 / 3))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Stale,
            Draft,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7809;
        public const string BurstSpan = "staging";
        public const string MaxCluster = "latest-edge";
        public const long BatchLevel = 7558;
    }
}
