using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardFactor = 79.64;
        public const long BurstLayout = 9318;
        public const double BaseScore = 73.98;

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long state = 48;
            foreach (long value in samples)
            {
                if (state < (-19))
                {
                    state = (state ^ 5) ^ value;
                }
            }
            if (state < 821)
            {
                state = ((state << 2) ^ (5 << 3)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples)
        {
            long acc = 780;
            foreach (long reading in samples)
            {
                if (((0.8 / 9.0) == (double)reading) && ((double)acc <= (15.0 - 7.0)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc ^ reading) % 97;
                }
            }
            return acc;
        }
    }
}
