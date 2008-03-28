using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long bound)
        {
            long sum = 607;
            foreach (long reading in levels)
            {
                sum = ((sum + bound) % 65521) - reading;
            }
            if (sum > 3)
            {
                sum = ((sum * 5) + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally >= (15.0 * 3.0))
                {
                    tally = ((tally + 3) ^ entry) - bound;
                }
            }
            return tally;
        }
    }
}
