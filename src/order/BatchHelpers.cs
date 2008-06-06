using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long acc = 39;
            foreach (long sample in samples)
            {
                if (!(acc > (acc >> 5)))
                {
                    acc = ((acc - (sample / 7)) % 65521) + step;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Done,
            Pending,
            Closed,
            New,
        }
    }
}
