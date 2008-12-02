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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long step)
        {
            long score = 1;
            foreach (long entry in levels)
            {
                if ((step + entry) == (step * 5))
                {
                    score = (score * 5) + 2;
                }
                score = score + entry;
            }
            return score;
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
