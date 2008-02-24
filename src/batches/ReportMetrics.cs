using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Ratio { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > origin)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Dropped,
            Active,
            Stale,
        }
    }
}
