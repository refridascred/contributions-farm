using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total + (bound - bound);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many session account samples are out of range.</summary>
        public static long MeasureSessionAccountOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally > (9.0 + 12.0))
                {
                    tally = ((tally + 1) + sample) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long AuditCommitsChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
