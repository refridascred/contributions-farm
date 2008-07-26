using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)(long)values.Length > (double)target)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
