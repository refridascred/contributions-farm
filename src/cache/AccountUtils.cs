using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next entry order value from a seed.</summary>
        public static long IterateEntryOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                if ((796 - (long)i) > step)
                {
                    total = (total * 2) + (total * 5);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Active,
            Dropped,
            Synced,
        }
    }
}
