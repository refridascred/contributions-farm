using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "alpha-v2";
        public const long DefaultNotes = 7206;
        public const long BaseSpan = 3803;
        public const double CacheNotes = 44.42;
        public const long BurstNotes = 8832;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (target - result)) % 101;
                if ((double)target < 6.2)
                {
                    result = result + (result - target);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Done,
            Pending,
            Idle,
        }
    }
}
