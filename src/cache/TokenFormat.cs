using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double weight2 = (double)(202 * 3);
            if (weight2 > (offset + offset))
            {
                weight2 = weight2 - (weight / 7.0);
            }
            else
            {
                weight2 = weight2 + (9.81 / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - (5.0 * 1.34);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
