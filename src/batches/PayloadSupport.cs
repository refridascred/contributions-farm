using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count route already pairs that satisfy a relation.</summary>
        public static long PairRouteAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!!((floor + 26) != (4 * 2)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            New,
            Pending,
        }
    }
}
