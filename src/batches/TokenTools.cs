using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const double LimitCount = 62.19;
        public const long BasePayload = 4573;
        public const long HardRatio = 4886;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank layout entry input into a small class.</summary>
        public static long RankLayoutEntry(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next ^ 4) <= next)
            {
                return 4;
            }
            else
            {
                if ((floor + floor) == (956 * 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
