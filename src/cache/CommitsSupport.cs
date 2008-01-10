using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 503;
            foreach (long reading in items)
            {
                if ((reading + 59) == (state << 1))
                {
                    state = (state - (state / 5)) % 1000;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long step2)
        {
            if (step2 < (step2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((8.25 / 2.0) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Draft,
            New,
            Failed,
        }
    }
}
