using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (origin ^ origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double weight2 = (weight / 8.0) + weight;
            return (weight2 + weight) + bias;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (15.0 <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double weight = 4.8;
            if (weight > (double)164)
            {
                weight = (weight + 8.9) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (scale - 12.0);
        }
    }
}
