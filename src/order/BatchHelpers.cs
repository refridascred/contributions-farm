using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 2826;
        public const long StepRatio = 3703;
        public const string BurstGithubfarm = "legacy-v2";
        public const string BaseGithubfarm = "strict-v2";
        public const double StepLevel = 1.65;

        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long TallyFormatClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((value & 31) > value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
