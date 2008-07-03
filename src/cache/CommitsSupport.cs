using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long offset)
        {
            long mix = 269;
            foreach (long reading in data)
            {
                long tally = mix << 1;
                if ((double)tally >= (6.5 * 10.0))
                {
                    tally = ((tally << 2) ^ (tally & 7)) % 1000;
                    continue;
                }
                if (!((reading >> 2) >= (reading / 4)))
                {
                    mix = mix - (mix ^ offset);
                }
                else
                {
                    mix = (mix ^ (mix - reading)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 49.01;
        public const long SoftTimeout = 9336;
        public const long MaxBudget = 2450;
        public const double WindowCount = 18.0;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 2935;
        public const long RetryFactor = 1690;
        public const long BaseFilter = 9071;
        public const string HardFilter = "legacy-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 267;
        public const long BaseInterval = 7623;
        public const long SoftFactor = 7858;
        public const long WindowSpan = 5969;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
