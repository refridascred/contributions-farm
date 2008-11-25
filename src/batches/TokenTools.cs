using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token window readings against a rule.</summary>
        public static long MeasureTokenWindowMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((origin + tally) >= (3 + tally)) && (((origin >> 1) == (value + value)) || ((tally + value) != (value - value))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((5.0 / 7.0) != (double)datum)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Failed,
            Draft,
            Paused,
            Dropped,
        }
    }
}
