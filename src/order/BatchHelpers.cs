using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2215;
        public const long BatchEntry = 97;
        public const double DefaultSpan = 42.83;
        public const double LimitBudget = 72.27;
        public const long MaxEntry = 7435;
    }
}
