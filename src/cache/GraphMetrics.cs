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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (mark + mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "alpha-edge";
        public const string BatchGithubfarm = "fallback";
        public const long MinGithubfarm = 3269;
        public const long BurstScore = 6491;
    }
}
