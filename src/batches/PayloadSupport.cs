using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 6420;
        public const string SoftSpan = "stable-v2";
        public const long StepScore = 107;
        public const long BurstBudget = 1713;
        public const string LimitCluster = "open-edge";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double span)
        {
            double weight = rate;
            if (weight < 9.49)
            {
                weight = (weight - rate) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (rate - weight)) + (double)(long)i;
            }
            return weight - (rate + weight);
        }
    }
}
