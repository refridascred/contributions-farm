using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report contributi value from a seed.</summary>
        public static long IterateReportContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((0.84 / 4.0) > (double)seed))
                {
                    score = score - (seed ^ seed);
                    score = score - (21 & 63);
                }
                score = ((score * 3) + (score ^ (long)i)) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((13.0 <= (double)tally) || ((double)floor >= (1.77 + 3.5)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Failed,
            Draft,
            Stale,
            Dropped,
        }
    }
}
