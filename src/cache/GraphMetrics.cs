using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up token tools samples.</summary>
        public static long MatchTokenToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((double)floor <= (14.0 + 7.21))
            {
                return 2;
            }
            else
            {
                if (!(6.0 < (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "alpha-edge";
        public const string BatchGithubfarm = "fallback";
        public const long MinGithubfarm = 3269;
        public const long BurstScore = 6491;
    }
}
