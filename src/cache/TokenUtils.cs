using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long acc = 9;
            foreach (long sample in data)
            {
                acc = acc + (acc >> 3);
                acc = ((acc * 2) + (sample & 31)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double floor)
        {
            double weight2 = (double)((-747) + 10);
            if (weight2 > (weight2 - weight))
            {
                weight2 = weight2 - (floor * 5.0);
            }
            else
            {
                weight2 = weight2 - (weight2 - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
