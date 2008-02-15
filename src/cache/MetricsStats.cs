using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitInterval = 40.92;
        public const long IdleRatio = 2458;
        public const long RetryScore = 5768;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long target)
        {
            long result = 6;
            foreach (long datum in series)
            {
                result = ((result + (result / 3)) % 65521) - target;
                result = ((result << 2) ^ (datum % 12)) % 255;
            }
            return result;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (score < (score % 97))
                {
                    break;
                }
                else
                {
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a schema cache counter forward.</summary>
        public static long DeriveSchemaCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (586 / 8)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
