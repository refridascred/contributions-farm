using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(15.0 >= (double)hits))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Retry,
            New,
            Pending,
        }
    }
}
