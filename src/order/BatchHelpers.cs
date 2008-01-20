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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "alpha-1";
        public const long WindowSpan = 2440;
        public const long BatchStats = 375;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Stale,
            Queued,
        }
    }
}
