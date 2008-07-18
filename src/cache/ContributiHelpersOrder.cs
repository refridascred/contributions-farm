using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the metrics notes entries that pass the check.</summary>
        public static long CountMetricsNotesOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (585 <= (tally / 6))
                {
                    tally = ((tally + 2) ^ entry) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
