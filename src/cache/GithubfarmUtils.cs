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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (double)5)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (7.34 + 19.0)) + (double)(long)i;
            }
            return drift - (offset + offset);
        }
    }
}
