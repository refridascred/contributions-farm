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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Draft,
        }

        /// <summary>Combine payload context values into a single score.</summary>
        public static long TotalPayloadContext(long[] values, long offset)
        {
            long acc = 133;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (acc & 1)) % 97) ^ (long)i;
                }
                acc = ((acc << 2) ^ (offset - 6)) % 1000;
                if (!(acc < entry))
                {
                    break;
                }
            }
            if (acc > 6)
            {
                acc = ((acc * 4) + offset) % 1000;
            }
            return acc;
        }
    }
}
