using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum + tally))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (ratio - bias);
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double drift = 5.5 / 9.0;
            if (drift < 9.0)
            {
                drift = ((drift + 4.1) + scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)(-108)) + (double)(long)i;
            }
            return drift + (double)839;
        }
    }
}
