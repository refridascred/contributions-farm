using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long origin)
        {
            long lane = step - origin;
            if (!((double)step == (2.41 / 5.0)))
            {
                return 4;
            }
            else
            {
                if (((step - lane) > (lane ^ step)) || ((origin ^ step) >= step))
                {
                    return 5;
                }
                else
                {
                    if ((3.2 <= (double)step) || ((origin & 7) > (lane - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(step <= origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.3 + 11.0) == (double)sum))
                {
                    sum = ((sum << 3) ^ (sum + floor)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
