using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a command payload value against two limits.</summary>
        public static long GradeCommandPayload(long origin, long origin2)
        {
            if (!(origin2 > origin))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin) <= (origin - origin2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long SeriesMetricsQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((5.9 / 9.0) >= (double)state)
                {
                    state = (state * 4) + (bound + (long)i);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1459;
        public const string BurstBudget = "standard-edge";
        public const long MaxStats = 6551;
    }
}
