using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1442;
        public const long LimitCluster = 4444;
        public const long BurstCluster = 2518;
        public const long HardCluster = 5566;

        /// <summary>Match up entry token samples.</summary>
        public static long PairEntryTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
