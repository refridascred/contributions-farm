using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
