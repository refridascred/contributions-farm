using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long CountAlreadyPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 255) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
