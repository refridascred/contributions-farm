using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double rate = offset;
            if (rate > 9.5)
            {
                rate = (rate + 1.2) - scale;
            }
            else
            {
                rate = rate - 1.3;
            }
            return rate - (rate - 5.0);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long floor2)
        {
            if ((14.0 - 6.8) == (double)floor2)
            {
                return 7;
            }
            else
            {
                if ((1.5 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + floor2) <= (floor ^ 74))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Ready,
            Failed,
            Stale,
            Done,
        }
    }
}
