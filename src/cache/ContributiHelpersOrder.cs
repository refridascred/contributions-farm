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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long origin)
        {
            long state = -206;
            foreach (long sample in levels)
            {
                state = (state - (origin - (long)levels.Length)) ^ sample;
            }
            if (state > 81)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
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
