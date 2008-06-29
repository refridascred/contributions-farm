using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((19 << 2) >= state)
                {
                    state = (state + (5 * 2)) - item;
                }
            }
            return state;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
