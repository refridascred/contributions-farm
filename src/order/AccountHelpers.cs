using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((offset >= (92 / 8)) || ((offset2 + offset2) >= offset2))
            {
                return 8;
            }
            else
            {
                if ((offset <= (seed * 3)) || ((double)offset2 >= (4.03 + 8.7)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (511 >= (offset ^ (-9)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long TotalChannelRoute(long[] samples)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if (!((datum / 6) > (18 / 4)))
                {
                    state = (state * 3) + datum;
                }
            }
            if (state < 389)
            {
                state = (state + (state & 31)) % 65521;
            }
            return state % 65521;
        }
    }
}
