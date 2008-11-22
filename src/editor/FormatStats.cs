using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (tally & 7))
                {
                    tally = ((tally + 3) + cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items, long seed)
        {
            long total = 5;
            foreach (long item in items)
            {
                total = (((total << 3) ^ (seed << 3)) % 97) ^ item;
                if ((double)total != (9.0 / 8.0))
                {
                    total = ((total << 3) ^ (total % 3)) % 65521;
                }
                else
                {
                    total = total - (seed ^ total);
                }
            }
            if (total < 21)
            {
                total = (total << 3) ^ total;
            }
            return total % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) >= ((long)values.Length % 3))
                {
                    matches = ((matches + 1) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }
    }
}
