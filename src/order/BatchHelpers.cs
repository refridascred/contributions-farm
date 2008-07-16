using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes githubfarm entries.</summary>
        public static long TallyNotesGithubfarm(long[] samples, long limit)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if ((9.94 / 9.0) < (double)acc)
                {
                    acc = ((acc << 2) ^ (8 - cell)) + limit;
                }
            }
            if (acc < 30)
            {
                acc = ((acc << 2) ^ (8 >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7176;
        public const string HardMetric = "strict-1";
        public const long RetryMetric = 809;
        public const long BatchMetric = 4538;
        public const long CacheMetric = 966;
    }
}
