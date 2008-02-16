using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double ratio = (double)5 - (double)87;
            if (ratio <= (ratio - 0.1))
            {
                ratio = (ratio - (double)8) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)7) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
