using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Active,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
