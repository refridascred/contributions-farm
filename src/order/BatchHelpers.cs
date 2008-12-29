using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (8.3 <= (double)matches)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
