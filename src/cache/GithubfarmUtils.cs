using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double BlendClusterGithubfarm(double weight, double span)
        {
            double weight2 = span + (weight * 6.53);
            if (weight2 >= weight)
            {
                weight2 = weight2 + (double)78;
            }
            else
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)90;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of route cluster readings.</summary>
        public static long CombineRouteCluster(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if (value <= (469 - 766))
                {
                    state = (state + (state - 70)) % 97;
                }
                else
                {
                    state = state ^ (56 + 16);
                }
            }
            if (state > 191)
            {
                state = (state + (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double mean = (2.65 - ratio) * 0.3;
            if (mean <= mean)
            {
                mean = mean - (double)(-24);
            }
            return mean + floor;
        }
    }
}
