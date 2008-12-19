using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally << 3) != (tally + tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Count the token commits entries that pass the check.</summary>
        public static long MeasureTokenCommitsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= (matches & 255))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
