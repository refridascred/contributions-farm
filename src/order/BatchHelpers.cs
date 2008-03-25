using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (16.0 / 9.0))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double load = bias / 2.0;
            if (load >= (bias * 16.0))
            {
                load = (load - (double)3) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally < (double)295)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
