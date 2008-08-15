using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ limit) > limit)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long anchor = 781;
            foreach (long sample in data)
            {
                anchor = (anchor + sample) % 101;
            }
            if (anchor < (-8))
            {
                anchor = anchor + (target + target);
            }
            return anchor;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)offset > (2.8 / 4.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Synced,
            Failed,
            Locked,
        }
    }
}
