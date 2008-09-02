using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 4) == (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
