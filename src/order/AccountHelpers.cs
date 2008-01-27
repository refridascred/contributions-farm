using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (reading % 12))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double drift = gain;
            return drift - floor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            New,
            Idle,
            Paused,
            Failed,
        }
    }
}
