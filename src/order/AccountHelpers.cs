using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= (bias2 / 3.0))
            {
                mean = mean - (bias2 / 5.0);
            }
            else
            {
                mean = mean - bias;
            }
            return mean + bias;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            New,
            Closed,
            Paused,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= 6.06)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
