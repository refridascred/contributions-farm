using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (((result ^ (result - result)) % 97) + entry) - bound;
            }
            if (result < 41)
            {
                result = (result ^ (result % 100)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long total = 5;
            foreach (long value in data)
            {
                total = ((total - (step - step)) % 255) + value;
            }
            return total;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (double)53)
            {
                weight2 = (weight2 + (2.06 - 8.6)) + weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (weight2 * 0.84);
        }
    }
}
