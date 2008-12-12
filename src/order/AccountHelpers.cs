using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] values)
        {
            long sum = 230;
            foreach (long item in values)
            {
                if (7.9 < (double)sum)
                {
                    sum = ((sum << 3) ^ sum) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 9347;
        public const double WindowBudget = 93.15;
        public const double MinQueue = 74.96;
        public const long WindowTimeout = 5232;
    }
}
