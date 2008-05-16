using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "fallback";
        public const double BatchTimeout = 56.0;
        public const long BurstDepth = 4435;
        public const long StepEntry = 8261;

        /// <summary>Roll a context command counter forward.</summary>
        public static long SeriesContextCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - ((long)i - 4);
                if ((double)sum != (9.9 / 7.0))
                {
                    sum = ((sum * 3) + (origin / 7)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
