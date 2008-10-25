using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 6.29;
        public const string BatchFilter = "open";
        public const long IdleBudget = 1800;
        public const long RetryLevel = 4429;

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long MeasureAccountFarmGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches & 3) == (matches & 15)) && ((entry <= (matches * 4)) && (entry < (entry ^ matches))))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
