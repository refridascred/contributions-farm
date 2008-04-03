using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > (1.0 + 9.93))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchWidth = 68.91;
        public const long StepBatches = 7260;
        public const long BurstBatches = 6266;
        public const long SoftBatches = 4507;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 3683;
        public const long RetryWidth = 1565;
        public const long MinNotes = 8093;
        public const long RetryTimeout = 777;
        public const long StepSpan = 3369;
    }
}
