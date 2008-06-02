using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double weight = bias;
            if (weight > scale)
            {
                weight = weight + (double)607;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 9081;
        public const long BatchWidth = 3704;
        public const string CacheSpan = "alpha-1";

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = (double)((-4) ^ 8);
            if (gain2 < 6.2)
            {
                gain2 = ((gain2 + (0.3 / 4.0)) - gain) + bias;
            }
            return gain2 + 10.0;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels, long origin)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                anchor = (anchor << 2) ^ (anchor - reading);
                anchor = (anchor + (21 >> 2)) % 101;
                if (origin <= (reading << 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
