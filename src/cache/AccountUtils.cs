using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 100) > 84)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
