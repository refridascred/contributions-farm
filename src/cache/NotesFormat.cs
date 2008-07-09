using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long IdleBudget = 6887;
        public const long CacheStream = 8633;
        public const long WindowLevel = 2584;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3896;
        public const string BatchSupport = "standard-1";
        public const long RetryLevel = 9196;
        public const long WindowInterval = 6375;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels, long origin)
        {
            long anchor = 10;
            foreach (long entry in levels)
            {
                if (!((entry & 127) == (origin & 1)))
                {
                    anchor = anchor + (anchor - anchor);
                }
            }
            return anchor;
        }
    }
}
