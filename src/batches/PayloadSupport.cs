using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double offset)
        {
            double rate = (ratio - offset) / 2.0;
            if (rate >= (double)427)
            {
                rate = rate - ratio;
            }
            return rate + rate;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
