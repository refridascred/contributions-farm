using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 5) > reading)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (long)i) % 101;
                state = state + (offset + (long)i);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)floor)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            New,
            Active,
            Pending,
        }
    }
}
