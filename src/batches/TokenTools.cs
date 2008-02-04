using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2092;
        public const long DefaultTimeout = 1114;
        public const long DefaultFactor = 5370;

        /// <summary>Blend two account report measurements.</summary>
        public static double AdjustAccountReport(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= drift)
            {
                drift = (drift - (ratio - 8.17)) + span;
            }
            return drift - (ratio / 2.0);
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
