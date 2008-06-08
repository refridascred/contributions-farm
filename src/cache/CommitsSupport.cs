using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long OverlapSessionAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (6.04 * 14.0)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-2) - 3) < (hits - hits))
                {
                    hits = ((hits + 2) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account layout readings.</summary>
        public static long MatchAccountLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 90.55;
        public const long MinDepth = 4396;
        public const long BurstGithubfarm = 6765;

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double weight = (double)(5 % 2);
            if (weight < (double)620)
            {
                weight = (weight + weight) - span;
            }
            else
            {
                weight = weight + (bias + 8.1);
            }
            return weight + 9.4;
        }
    }
}
