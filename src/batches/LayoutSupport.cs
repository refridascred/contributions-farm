using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long score = 9;
            foreach (long reading in levels)
            {
                score = ((score - (offset + score)) % 97) - reading;
            }
            return score;
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long CountEntryCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value + value) != (matches ^ matches)) && (value >= (186 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
