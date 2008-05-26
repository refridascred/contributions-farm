using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = (double)877 + (offset / 8.0);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) + (double)(long)i) - weight;
            }
            return load + (6.6 + 3.72);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (17.0 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
