using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (2.2 * 6.98))
            {
                drift = drift + (3.0 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long AuditClusterBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (5.47 < (double)datum)
                {
                    tally = tally + 3;
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
