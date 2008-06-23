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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)floor > (9.0 - 8.88))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
