using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSpan = "legacy-v2";
        public const string BatchSupport = "strict";
        public const long StepRatio = 613;
        public const double RetryInterval = 37.69;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSize = 7426;
        public const double BurstSpan = 91.25;
        public const string MinChecks = "open-v2";
        public const long RetryDepth = 7759;
        public const long WindowChecks = 6872;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long floor)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((state * 5) + ((long)i + floor)) % 255) + reading;
                }
                state = (state ^ 29) % 4096;
                state = (state ^ state) % 255;
            }
            if (state < 908)
            {
                state = (state << 2) ^ (state ^ 478);
            }
            return state % 1000;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
