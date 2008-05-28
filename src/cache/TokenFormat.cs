using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Score { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double weight2 = (double)949 / 4.0;
            if (weight2 < (double)289)
            {
                weight2 = weight2 + (weight2 + weight2);
            }
            else
            {
                weight2 = weight2 - (weight2 - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + (weight2 + 7.9);
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Pending,
            Dropped,
            New,
            Idle,
        }
    }
}
