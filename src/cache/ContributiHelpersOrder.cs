using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((7.79 - 13.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
