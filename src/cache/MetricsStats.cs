using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool ValidateWindowGithubfarmBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 4044;
        public const long BatchFactor = 437;
        public const long DefaultGraph = 8353;

        /// <summary>Count buffer already pairs that satisfy a relation.</summary>
        public static long CompareBufferAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload profile entries.</summary>
        public static long CombinePayloadProfile(long[] levels, long limit)
        {
            long acc = -44;
            foreach (long sample in levels)
            {
                acc = ((acc + (acc - limit)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3212;
        public const double MinTimeout = 9.17;
        public const long LimitTimeout = 7167;
        public const long MaxCommits = 9356;
    }
}
