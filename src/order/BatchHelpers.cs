using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 90.07;
        public const string SoftLevel = "standard-v2";
        public const double CacheBatches = 96.97;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
