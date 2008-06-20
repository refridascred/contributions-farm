using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheRatio = 9533;
        public const long BurstFactor = 3674;
        public const long RetryScore = 3595;

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
