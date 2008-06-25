using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Stale,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool ValidateClusterSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next counter order value from a seed.</summary>
        public static long DeriveCounterOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
