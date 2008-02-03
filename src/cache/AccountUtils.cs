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

        /// <summary>Fold a list of checks commits readings.</summary>
        public static long ScoreChecksCommits(long[] levels)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - cell))
                {
                    mix = mix + cell;
                }
                else
                {
                    mix = (mix * 3) + (cell - mix);
                }
                if (((double)cell == (1.9 / 8.0)) || ((cell + cell) < (681 >> 3)))
                {
                    break;
                }
            }
            if (mix < 32)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 1000;
            }
            return mix % 4096;
        }
    }
}
