using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            New,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Find the first batches window entry that matches the target.</summary>
        public static long SeekBatchesWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double span)
        {
            double bias2 = span / 5.0;
            return (bias2 + (bias2 * 4.2)) + bias;
        }
    }
}
