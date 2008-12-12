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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 2851;
        public const long RetryFactor = 1253;
        public const long DefaultCount = 3321;
        public const double DefaultDepth = 69.5;

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

        /// <summary>Roll a context checks counter forward.</summary>
        public static long SeriesContextChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + origin) % 255) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
