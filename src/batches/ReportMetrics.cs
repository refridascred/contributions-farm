using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long acc = 511;
            foreach (long cell in readings)
            {
                acc = ((acc - (acc - acc)) - cell) - origin;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long step)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                acc = ((acc - acc) % 4096) ^ item;
            }
            if (acc < 73)
            {
                acc = (acc + (step % 5)) % 255;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double floor)
        {
            double mean = (double)(6 * 3);
            if (mean > 13.0)
            {
                mean = (mean - (rate + mean)) - floor;
            }
            else
            {
                mean = mean + (mean * 4.3);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean - 3.0)) + (double)(long)i;
            }
            return mean + (mean * 18.0);
        }
    }
}
