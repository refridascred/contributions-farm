using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long acc = 408;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (acc << 2)) % 1000) + value;
            }
            return acc % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Synced,
            Done,
            Queued,
            New,
        }
    }
}
