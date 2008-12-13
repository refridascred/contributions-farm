using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a entry commits figure with a bias.</summary>
        public static double BlendEntryCommits(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - floor) - (double)(long)i) - scale;
            }
            return weight - (floor / 9.0);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long offset)
        {
            long acc = 24;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + cell) % 4096) - (long)i;
                    acc = acc - (offset * 4);
                }
                if ((17 + acc) <= acc)
                {
                    acc = acc + (acc * 4);
                }
                else
                {
                    acc = (acc + (offset / 8)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-15) % 24) != (step & 15)) || (tally <= (step - step)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
