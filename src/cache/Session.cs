using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftTimeout = 26.37;
        public const double LimitCount = 5.67;
        public const string HardTimeout = "staging";
        public const double BatchRoute = 56.97;
    }
}
