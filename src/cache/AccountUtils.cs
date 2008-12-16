using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batches queue figure with a bias.</summary>
        public static double ProjectBatchesQueue(double ratio, double span)
        {
            double load = 8.0 + 16.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load * 1.11)) - (double)(long)i) - ratio;
            }
            return load + span;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
