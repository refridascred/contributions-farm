using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Find the first record commits entry that matches the target.</summary>
        public static long LookupRecordCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
