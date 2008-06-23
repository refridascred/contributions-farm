using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((offset & 31) > (count >> 4))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc - ((long)i % 7)) - origin;
                }
                acc = (acc - (cell % 16)) % 255;
                if ((cell + (long)samples.Length) < (acc % 10))
                {
                    acc = acc + (cell - cell);
                }
            }
            if (acc < 17)
            {
                acc = (acc - 69) % 255;
            }
            return acc;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleLevel = 17.57;
        public const long MaxSpan = 4990;
        public const string BaseWidth = "local";
        public const double WindowBatch = 28.94;
        public const long StepLevel = 294;
    }
}
