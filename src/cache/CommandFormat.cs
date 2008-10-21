using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long acc = 22;
            foreach (long datum in values)
            {
                if (datum < (893 + 15))
                {
                    acc = ((acc << 3) ^ (acc - datum)) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (datum - acc);
                }
            }
            if (acc < 3)
            {
                acc = ((acc << 3) ^ (acc * 5)) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = mean + 9.15;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)396) + (double)(long)i;
            }
            return mean - (weight - mean);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 3) >= count) || ((count << 3) >= ((-57) + 383)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double span)
        {
            double mean = (double)525 / 8.0;
            if (mean > 1.32)
            {
                mean = (mean + (mean / 3.0)) - weight;
            }
            return mean - span;
        }
    }
}
