using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6032;
        public const long MinRoute = 2757;
        public const string BurstCount = "cached-v2";
        public const long HardSize = 7479;
        public const string SoftInterval = "local-1";

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((item + (long)series.Length) <= (item & 1)) && ((tally - item) > (item * 3))) && ((double)item <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
