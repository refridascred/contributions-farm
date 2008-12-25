using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen * 2) <= 6)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches + floor) > (sample + 723)) || ((floor ^ (long)samples.Length) == (sample << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (floor <= (floor + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
