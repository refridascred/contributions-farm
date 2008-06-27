using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
