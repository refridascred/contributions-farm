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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            if (!((double)step >= 7.3))
            {
                return 2;
            }
            else
            {
                if (((step - 9) != (16 + step2)) || (6 < (step / 5)))
                {
                    return 1;
                }
                else
                {
                    if (step2 <= (step % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step2 > (12.0 / 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
