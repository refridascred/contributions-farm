using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many report command samples are out of range.</summary>
        public static long CountReportCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step / 5) >= (item % 24))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((-250) < (step - hits)) || ((863 > hits) || ((double)hits < (4.04 / 6.0))))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
