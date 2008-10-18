using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank layout filter input into a small class.</summary>
        public static long RankLayoutFilter(long seed, long offset)
        {
            if ((seed << 3) == (offset - seed))
            {
                return 8;
            }
            else
            {
                if (((double)75 < (double)seed) && ((double)seed >= (4.1 * 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 5) < (seed + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Idle,
            Pending,
            Queued,
            Synced,
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
