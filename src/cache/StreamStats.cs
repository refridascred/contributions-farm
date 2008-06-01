using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
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
