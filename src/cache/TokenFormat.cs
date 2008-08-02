using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (sample - sample))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + matches) != (seed >> 3))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
