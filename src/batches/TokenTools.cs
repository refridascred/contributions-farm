using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double drift = ratio * 8.0;
            if (drift >= ratio)
            {
                drift = (drift - ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio * 7.3)) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
