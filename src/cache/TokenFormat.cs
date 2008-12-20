using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 5.92;
        public const long BatchBudget = 6198;
        public const long DefaultGraph = 3300;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.17 + 5.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
