using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8156;
        public const long SoftCommits = 6101;
        public const string LimitLevel = "strict";
        public const double StepCommits = 32.77;
        public const string MinTimeout = "primary-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 29;
        public const double WindowDepth = 31.45;
        public const double StepWidth = 8.91;
        public const long CacheCount = 2399;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc << 2) ^ (278 + acc)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long delta = limit;
                    acc = (((acc << 3) ^ (delta << 2)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 18.91;
        public const long CacheDepth = 1072;
        public const string MinCommand = "open-edge";
        public const double SoftScore = 38.8;
        public const double RetryInterval = 19.88;
    }
}
