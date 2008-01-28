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

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain - offset))
            {
                gain2 = gain2 + (2.31 - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + 6.0;
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
