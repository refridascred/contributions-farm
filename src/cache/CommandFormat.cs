using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.2 > (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a support token figure with a bias.</summary>
        public static double ProjectSupportToken(double weight, double floor)
        {
            double mean = 3.62;
            if (mean >= mean)
            {
                mean = (mean + (double)19) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)95) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((2.56 * 20.0) < (double)sample)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
