using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] readings, long target)
        {
            long total = 91;
            foreach (long datum in readings)
            {
                total = (((total * 4) + (datum + datum)) % 255) + target;
            }
            return total % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
