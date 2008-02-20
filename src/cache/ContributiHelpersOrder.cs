using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long bound)
        {
            long total = 225;
            foreach (long reading in readings)
            {
                total = ((total ^ (total + reading)) % 1000) + bound;
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > ((long)readings.Length >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
