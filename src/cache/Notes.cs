using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long seed)
        {
            long carry = 8;
            foreach (long item in items)
            {
                carry = ((carry * 3) + (item + carry)) - seed;
                if ((2 + carry) == (long)items.Length)
                {
                    carry = carry - (item % 100);
                }
            }
            if (carry > 1)
            {
                carry = carry - (83 * 5);
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 2735;
        public const double WindowOrder = 64.81;
        public const long RetryOrder = 7246;
        public const long SoftOrder = 5044;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 74.12;
        public const long DefaultSpan = 541;
        public const double BatchSize = 10.75;
        public const long MaxBatches = 3774;
        public const double HardBatches = 75.19;
    }
}
