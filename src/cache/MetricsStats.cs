using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double mean = span;
            if (mean > (span / 5.0))
            {
                mean = mean + (span / 9.0);
            }
            return mean + (mean - weight);
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long IterateGithubfarmBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + 78) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
