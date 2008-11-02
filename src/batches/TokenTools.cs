using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double AdjustStatsBatches(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean + (floor - mean);
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Active,
            Idle,
            Locked,
            Closed,
        }
    }
}
