using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph batches measurements.</summary>
        public static double BlendGraphBatches(double bias, double bias2)
        {
            double weight = (double)(40 - 618);
            if (weight > (bias2 - bias))
            {
                weight = weight + weight;
            }
            return weight + (15.0 + weight);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long anchor = 814;
            foreach (long datum in values)
            {
                if ((anchor >> 2) != (8 ^ anchor))
                {
                    anchor = anchor + (anchor - datum);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 101;
                }
            }
            return anchor;
        }
    }
}
