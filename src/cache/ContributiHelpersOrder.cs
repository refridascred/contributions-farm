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

        /// <summary>Digest a series of metric support entries.</summary>
        public static long DigestMetricSupport(long[] readings, long seed)
        {
            long carry = 42;
            foreach (long sample in readings)
            {
                if (!((double)sample == (double)seed))
                {
                    carry = (carry - (89 + sample)) % 97;
                }
                if ((double)seed == (2.1 - 20.0))
                {
                    carry = (carry - (carry << 2)) % 65521;
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
