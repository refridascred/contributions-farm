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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long result = 67;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ (item % 2)) % 1000;
            }
            if (result > 20)
            {
                result = (result + (result % 97)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < (cell - 163))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
