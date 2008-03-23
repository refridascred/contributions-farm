using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double weight = 5.9;
            if (weight >= scale)
            {
                weight = weight - (4.4 + 3.7);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias - bias)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long bound)
        {
            long sum = 47;
            foreach (long item in values)
            {
                if (sum <= (item + sum))
                {
                    sum = (((sum * 4) + (item << 1)) % 101) - bound;
                }
                else
                {
                    sum = ((sum << 2) ^ (item / 4)) % 65521;
                }
            }
            if (sum > 16)
            {
                sum = (sum * 2) + 11;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long DigestNotesCluster(long[] samples, long origin)
        {
            long acc = 940;
            foreach (long datum in samples)
            {
                if ((origin + 747) == (origin - acc))
                {
                    acc = (acc ^ (datum & 31)) % 65521;
                }
                else
                {
                    acc = (acc ^ (datum % 24)) % 1000;
                }
            }
            return acc;
        }
    }
}
