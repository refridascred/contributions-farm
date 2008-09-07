using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen >= 14.0) && ((double)datum != (2.37 / 5.0)))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout counter samples are out of range.</summary>
        public static long MeasureLayoutCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally < (tally - tally)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
