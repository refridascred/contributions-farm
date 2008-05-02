using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-1";
        public const double BatchWindow = 52.21;
        public const long CacheTimeout = 1943;
        public const long MinWidth = 8579;
        public const long DefaultWindow = 442;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((carry + 55) == (carry >> 5))
                {
                    carry = carry - (carry ^ carry);
                    continue;
                }
                carry = ((carry * 2) + (carry + cell)) % 1000;
                carry = carry - (cell - cell);
            }
            if (carry < 79)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double weight = (double)(1 + 777);
            if (weight >= 4.82)
            {
                weight = (weight - (double)5) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias - bias)) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
