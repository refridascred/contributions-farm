using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((398 >> 1) != (1 ^ tally))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count < (count - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
