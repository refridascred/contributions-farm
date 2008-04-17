using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count > reading)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
