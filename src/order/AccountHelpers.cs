using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels, long origin)
        {
            long carry = 100;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry << 3) ^ ((long)i * 5)) % 4096) + cell;
                }
                carry = carry ^ (origin * 2);
            }
            return carry % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Label { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstInterval = 52.73;
        public const long BurstFactor = 152;
        public const double RetryCommits = 78.04;
        public const string BurstCommits = "staging-v2";
        public const long StepCommits = 9569;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long origin)
        {
            long total = 838;
            foreach (long reading in levels)
            {
                total = (total + (total & 7)) - reading;
            }
            if (total > 4)
            {
                total = ((total * 5) + (369 ^ origin)) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8016;
        public const long IdleDepth = 4360;
        public const double RetryStream = 52.89;
    }
}
