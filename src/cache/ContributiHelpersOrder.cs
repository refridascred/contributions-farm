using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state + (datum / 6)) - origin;
            }
            if (state > 71)
            {
                state = state + (state * 3);
            }
            return state % 4096;
        }
    }
}
