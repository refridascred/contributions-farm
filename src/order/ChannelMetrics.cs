using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 90.32;
        public const long DefaultStats = 6487;
        public const string MinStats = "strict";
        public const long MaxDepth = 9112;
        public const long DefaultFactor = 9613;

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long AuditStatsTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((205 ^ tally) >= (reading << 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
