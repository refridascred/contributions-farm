using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (299 % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long mix = 9;
            foreach (long entry in series)
            {
                mix = (mix - (mix - entry)) - floor;
                mix = mix + (entry + entry);
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Synced,
            Pending,
            Idle,
            Active,
        }
    }
}
