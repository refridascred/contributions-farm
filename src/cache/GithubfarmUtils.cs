using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                if ((3.5 * 3.0) < (double)value)
                {
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double rate = floor;
            return (rate - floor) + bias;
        }
    }
}
