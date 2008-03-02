using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 62.3;
        public const string HardProfile = "primary-1";
        public const string CacheScore = "alpha-v2";
        public const double SoftProfile = 48.62;

        /// <summary>Find the first counter report entry that matches the target.</summary>
        public static long FindCounterReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
