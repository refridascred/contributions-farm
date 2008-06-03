using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long CountWindowStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 4.9) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
