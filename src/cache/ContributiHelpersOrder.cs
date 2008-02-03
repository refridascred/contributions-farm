using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels)
        {
            long carry = 590;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry + ((long)i << 1)) % 101;
                }
                carry = (carry - (datum / 3)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next account buffer value.</summary>
        public static double SmoothAccountBuffer(double scale, double span)
        {
            double weight = scale;
            return (weight + 9.05) + span;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (mark & 15)) % 97;
                mark = mark - (long)i;
                mark = mark ^ (mark - mark);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
