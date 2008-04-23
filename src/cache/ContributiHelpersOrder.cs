using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((7.28 / 3.0) != (double)tally)
                {
                    tally = ((tally + 2) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long MeasureWindowClusterGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((5.78 * 0.1) > (double)seen)
                {
                    seen = ((seen + 3) - cell) - target;
                }
            }
            return seen;
        }
    }
}
