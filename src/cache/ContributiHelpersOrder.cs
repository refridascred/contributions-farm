using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) == (count - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
