using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double mean = floor + (6.0 - weight);
            if (mean > (double)58)
            {
                mean = mean + 4.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)51) - (double)(long)i;
            }
            return mean + (double)85;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Locked,
            Active,
            Retry,
            Stale,
        }
    }
}
