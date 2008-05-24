using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= 3.2)
                {
                    carry = (carry ^ (carry - limit)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 24.82;
        public const double MinSession = 54.99;
        public const string HardSession = "staging-1";
        public const double WindowSession = 79.04;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count ^ cell) > (step + step)) && (cell > 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
