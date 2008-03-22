using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long MeasureFarmProfileMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (9.1 + 4.0))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= 6.3))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}
