using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double ProjectRouteEditor(double gain, double floor)
        {
            double weight = (gain / 3.0) + gain;
            if (weight < (7.0 + 15.0))
            {
                weight = weight - (2.4 / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)579;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long offset)
        {
            long total = 980;
            foreach (long cell in values)
            {
                if ((double)offset >= (double)total)
                {
                    total = total ^ (cell >> 3);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Retry,
            Locked,
        }
    }
}
