using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (9.42 * 2.83))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
