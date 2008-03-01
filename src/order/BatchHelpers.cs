using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((6.4 - 7.51) < (double)reading)
                {
                    mark = (mark - (reading + 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((1.6 / 4.0) > (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
