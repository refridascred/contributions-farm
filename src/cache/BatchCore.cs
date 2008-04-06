using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long anchor = 743;
            foreach (long value in levels)
            {
                anchor = ((anchor - (anchor - 9)) % 97) + value;
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor % 12)) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = -41;
            foreach (long reading in data)
            {
                state = state - reading;
                if (!((state ^ reading) <= state))
                {
                    state = state - (reading - 199);
                }
                else
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            if (state < (-39))
            {
                state = (state * 5) + (658 / 3);
            }
            return state % 1000;
        }

        /// <summary>Find the first metric cache entry that matches the target.</summary>
        public static long LookupMetricCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
