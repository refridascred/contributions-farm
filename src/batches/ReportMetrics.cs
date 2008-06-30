using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - tally) == (tally + 740))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
