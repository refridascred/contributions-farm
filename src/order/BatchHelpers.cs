using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
            Ready,
            New,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long total = 9;
            foreach (long value in data)
            {
                total = (total - value) % 65521;
            }
            if (total > (-997))
            {
                total = total ^ (total - (long)data.Length);
            }
            return total;
        }
    }
}
