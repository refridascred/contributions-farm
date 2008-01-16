using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of context cluster readings.</summary>
        public static long MatchContextClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
