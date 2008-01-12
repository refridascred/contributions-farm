using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Grade a cluster batch value against two limits.</summary>
        public static long RankClusterBatch(long step, long offset)
        {
            long cur = step + offset;
            if ((step - cur) <= 696)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) <= (step % 10))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Dropped,
            Pending,
            Ready,
        }
    }
}
