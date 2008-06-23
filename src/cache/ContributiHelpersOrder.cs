using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema format value.</summary>
        public static double AdjustSchemaFormat(double weight, double floor)
        {
            double weight2 = weight;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 + (weight * 20.0)) - (double)(long)i) - floor;
            }
            return weight2 + 2.9;
        }

        /// <summary>Look up the position of a session context sample.</summary>
        public static long LookupSessionContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 610;
            foreach (long datum in series)
            {
                if ((datum - result) > (result + datum))
                {
                    result = ((result << 2) ^ (result - 657)) % 65521;
                }
            }
            return result;
        }
    }
}
