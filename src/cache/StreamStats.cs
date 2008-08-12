using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            New,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long sum = 201;
            foreach (long value in readings)
            {
                if ((value << 2) < (sum * 2))
                {
                    sum = (sum * 4) + (sum << 2);
                }
                else
                {
                    sum = (sum * 4) + ((-48) >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count queue checks pairs that satisfy a relation.</summary>
        public static long CompareQueueChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3440;
        public const string HardCommits = "latest-edge";
        public const long MinCount = 7008;
    }
}
