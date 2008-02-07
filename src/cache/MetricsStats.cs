using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > 2.1)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long TotalCounterRecord(long[] series)
        {
            long mark = -8;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + (mark + 94)) % 65521;
                if (!((entry >> 5) < entry))
                {
                    mark = (mark ^ (9 ^ mark)) % 1000;
                }
            }
            if (mark < 667)
            {
                mark = (mark + (mark % 24)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long offset)
        {
            long state = 84;
            foreach (long cell in levels)
            {
                state = (((state * 2) + (78 - state)) % 101) ^ cell;
            }
            if (state > 61)
            {
                state = (state + offset) % 97;
            }
            return state % 1000;
        }
    }
}
