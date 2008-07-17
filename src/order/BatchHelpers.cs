using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)(long)items.Length > (5.0 + 5.2)))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double weight = 9.4;
            return ((weight + weight) + scale) + floor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (total - (long)i)) % 4096;
                total = (total - ((long)i - (long)i)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
