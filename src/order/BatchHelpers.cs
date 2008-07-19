using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i - state) > 76)
                {
                    state = (state ^ (state + seed)) % 97;
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
