using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit window already readings against a rule.</summary>
        public static long TallyWindowAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (3.53 * 17.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally / 8) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >> 2) != (tally * 2))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
