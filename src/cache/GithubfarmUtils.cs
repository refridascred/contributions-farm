using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a window order figure with a bias.</summary>
        public static double BlendWindowOrder(double scale, double bias)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = rate + 7.0;
            }
            return rate + bias;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Dropped,
            Draft,
            Done,
        }
    }
}
