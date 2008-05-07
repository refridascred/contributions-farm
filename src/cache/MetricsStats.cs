using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long offset)
        {
            if ((73 + 319) >= (bound * 4))
            {
                return 5;
            }
            else
            {
                if ((14.0 + 4.3) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((52 >> 5) != (offset * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + ((long)i / 9)) % 101;
                if (origin >= mark)
                {
                    mark = (mark * 5) + mark;
                    mark = (mark * 5) + (mark + origin);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
