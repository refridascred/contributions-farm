using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = (drift - drift) + scale;
            }
            return drift + (double)3;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 9251;
        public const string WindowBudget = "strict-v2";
        public const long RetryPayload = 2508;
        public const double BatchPayload = 81.93;
        public const long WindowLevel = 7182;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
