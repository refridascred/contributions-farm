using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultScore = 8300;
        public const long HardRatio = 8354;
        public const long MinCache = 7651;
        public const long BurstCache = 9985;
        public const string BatchCache = "stable-v2";

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long floor)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = ((sum - reading) % 97) + floor;
            }
            return sum % 4096;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ 5;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
