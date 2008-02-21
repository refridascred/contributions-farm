using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of batch token readings.</summary>
        public static long ScoreBatchToken(long[] levels, long bound)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                sum = sum + datum;
            }
            if (sum > 270)
            {
                sum = sum - (bound + 3);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 18.85;
        public const long MinNotes = 6993;
        public const long StepNotes = 6037;
    }
}
