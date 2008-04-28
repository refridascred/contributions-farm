using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batches commits value.</summary>
        public static double BlendBatchesCommits(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < 4.0)
            {
                scale = scale + (double)0;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - bias;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Locked,
            Retry,
            Synced,
            Draft,
        }
    }
}
