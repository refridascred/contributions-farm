using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ seed) != (seed + seed))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items)
        {
            long result = 65;
            foreach (long reading in items)
            {
                result = (result ^ (reading % 24)) % 1000;
            }
            return result;
        }
    }
}
