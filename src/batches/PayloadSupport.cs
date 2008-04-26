using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(10 < (value * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels)
        {
            long anchor = -31;
            foreach (long entry in levels)
            {
                if ((1.6 - 5.66) <= (double)entry)
                {
                    anchor = (anchor - (entry + entry)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
