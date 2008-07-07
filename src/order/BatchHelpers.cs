using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long TallyCacheContributiHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (3.25 < (double)seed)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
