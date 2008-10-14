using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(hits < (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double weight = bias;
            if (weight >= gain)
            {
                weight = weight - (weight - 1.6);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)543) + (double)(long)i;
            }
            return weight + (double)62;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((45 - 9) >= hits)
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
