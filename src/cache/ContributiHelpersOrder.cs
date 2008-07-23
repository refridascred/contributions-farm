using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long acc = 785;
            foreach (long datum in levels)
            {
                if ((724 - acc) >= (acc - acc))
                {
                    acc = ((acc * 3) + (acc * 5)) + datum;
                }
            }
            if (acc < (-46))
            {
                acc = (acc * 2) + floor;
            }
            return acc % 65521;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double weight2 = offset - (offset / 8.0);
            if (weight2 <= (weight + weight2))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 - (offset - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - offset) + (double)(long)i;
            }
            return weight2 + (double)395;
        }
    }
}
