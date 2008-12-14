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
