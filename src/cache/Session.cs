using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4 + sample) != (tally >> 4))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items)
        {
            long state = 31;
            foreach (long entry in items)
            {
                state = (state ^ (entry + 59)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((long)values.Length <= 9)
                {
                    matches = ((matches + 2) ^ datum) - offset;
                }
            }
            return matches;
        }
    }
}
