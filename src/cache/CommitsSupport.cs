using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Ready,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long limit)
        {
            long delta = bound ^ limit;
            if (limit <= (20 / 7))
            {
                return 4;
            }
            else
            {
                if ((2.06 + 12.0) != (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) == (limit - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit != (3.38 * 16.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
