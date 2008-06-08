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

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double ScaleQueueAccount(double scale, double floor)
        {
            double bias = floor;
            if (bias <= scale)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - (3.0 - 9.0);
            }
            return bias + (floor - 1.45);
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

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
