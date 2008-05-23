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

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 958;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum - cell) % 97;
                    sum = sum - ((long)i ^ (long)i);
                }
                if ((cell & 1) != (790 + 1))
                {
                    sum = (sum * 5) + (cell - 90);
                }
            }
            return sum;
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
