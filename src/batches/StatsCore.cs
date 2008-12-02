using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Ready,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long ScoreNotesCache(long[] data, long target)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if (mark < (mark + 3))
                {
                    mark = mark + (target << 2);
                }
                if ((double)sample > 6.7)
                {
                    mark = (mark ^ (5 % 8)) % 1000;
                }
            }
            if (mark < 89)
            {
                mark = mark - (mark + 63);
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
