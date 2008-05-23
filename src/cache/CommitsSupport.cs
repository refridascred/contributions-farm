using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count stats editor pairs that satisfy a relation.</summary>
        public static long MatchStatsEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long target)
        {
            long bound = step - target;
            if ((2.8 + 16.0) <= (double)target)
            {
                return 0;
            }
            else
            {
                if (((bound - bound) >= bound) && ((target >> 1) < (target + bound)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= ((long)values.Length - hits))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
