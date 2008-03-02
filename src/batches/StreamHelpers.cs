using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((5.35 / 3.0) == (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                long count = (result ^ offset) - offset;
                if ((result - count) < ((long)i - (long)i))
                {
                    count = count - (result - result);
                }
                else
                {
                    count = count + ((long)i * 3);
                    count = (count - (result + offset)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1007;
        public const long HardWidth = 7954;
        public const long CacheScore = 5091;
        public const long DefaultGraph = 4164;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
