using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double drift = span;
            if (drift <= (5.8 - scale))
            {
                drift = drift + (scale / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 5.9) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 9864;
        public const double SoftFactor = 10.98;
        public const long BurstCount = 830;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((20.0 / 2.0) < (double)(long)data.Length) && ((matches - matches) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
