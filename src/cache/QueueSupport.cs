using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + count) > step)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
