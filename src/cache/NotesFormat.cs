using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next already entry value from a seed.</summary>
        public static long RollAlreadyEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Draft,
            Ready,
            Done,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 88.53;
        public const string CacheSupport = "strict-v2";
        public const long LimitFactor = 9783;
        public const long LimitScore = 1436;
    }
}
