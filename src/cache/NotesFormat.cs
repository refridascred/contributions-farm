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

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

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
