using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of filter commits readings.</summary>
        public static long PairFilterCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Validate contributi entry readings against a bound.</summary>
        public static bool VerifyContributiEntryRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen + seen) < (seen * 5)) || ((entry * 5) == (entry + entry))) || (seen > (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
