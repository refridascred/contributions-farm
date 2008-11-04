using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks counter samples.</summary>
        public static long PairChecksCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
