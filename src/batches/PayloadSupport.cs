using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - 11.0) + (double)(long)i) - floor;
            }
            return weight - ratio;
        }
    }
}
