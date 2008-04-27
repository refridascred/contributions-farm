using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double ratio = (double)((-9) * 4);
            if (ratio > 19.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias - gain)) + (double)(long)i;
            }
            return ratio - 4.5;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Dropped,
            Synced,
            New,
            Paused,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Queued,
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Active,
            Locked,
        }
    }
}
