using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] levels)
        {
            long sum = 92;
            foreach (long cell in levels)
            {
                long cur = sum;
                if ((double)cur > (19.0 / 2.0))
                {
                    sum = (sum ^ (cell << 3)) % 1000;
                }
                sum = ((sum << 2) ^ (3 % 2)) % 97;
            }
            return sum % 97;
        }
    }
}
