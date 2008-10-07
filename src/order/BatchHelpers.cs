using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long carry = 783;
            foreach (long sample in series)
            {
                carry = (carry + (offset & 1)) - sample;
            }
            if (carry > 24)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a contributi support figure with a bias.</summary>
        public static double SmoothContributiSupport(double gain, double bias)
        {
            double mean = (bias + gain) * 6.0;
            return mean - 2.51;
        }
    }
}
