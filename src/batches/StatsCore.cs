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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((5.0 - 12.0) >= (double)matches))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
