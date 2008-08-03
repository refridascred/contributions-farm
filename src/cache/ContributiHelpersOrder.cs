using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Fold a list of route metrics readings.</summary>
        public static long CombineRouteMetrics(long[] levels)
        {
            long carry = 3;
            foreach (long datum in levels)
            {
                if (((double)datum > (7.21 + 8.7)) || (carry < (carry + carry)))
                {
                    carry = (carry + (carry + carry)) % 1000;
                }
                else
                {
                    carry = (carry ^ datum) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((seed > (matches % 2)) || (datum < (seed >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
