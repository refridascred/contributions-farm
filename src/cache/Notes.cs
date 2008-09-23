using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double weight = offset + (gain * 11.0);
            if (weight <= weight)
            {
                weight = weight + (weight - 12.0);
            }
            else
            {
                weight = weight + (weight + gain);
            }
            return weight + (offset / 3.0);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long limit)
        {
            if ((limit + origin) <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if (!((double)origin >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + (bound >> 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowTimeout = 62.43;
        public const long IdleSize = 200;
        public const string IdleLevel = "legacy-edge";
    }
}
