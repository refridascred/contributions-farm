using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a schema counter reading.</summary>
        public static double ScaleSchemaCounter(double scale, double bias)
        {
            double drift = (scale - 2.0) / 9.0;
            if (drift < (double)(-209))
            {
                drift = (drift + drift) - bias;
            }
            return drift - (drift + drift);
        }
    }
}
