using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)972 != (double)(long)data.Length)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
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
