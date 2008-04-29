using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Synced,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 3) ^ ((long)i2 % 60)) % 255;
                    carry = (carry ^ (long)i2) % 4096;
                }
                carry = (carry + (8 / 2)) % 4096;
                if ((offset * 3) < (carry ^ carry))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
