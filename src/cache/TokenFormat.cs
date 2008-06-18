using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen % 10) < (132 & 255)) || ((seen ^ item) < item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a cluster farm reading by value.</summary>
        public static long FindClusterFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
