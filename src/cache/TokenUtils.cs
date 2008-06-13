using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 83.53;
        public const long MaxInterval = 8552;
        public const long HardTimeout = 816;
        public const long StepSupport = 8350;
        public const long CacheSupport = 600;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Pending,
            Synced,
            Queued,
        }
    }
}
