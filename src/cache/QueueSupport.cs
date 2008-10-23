using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 5244;
        public const long IdleScore = 8319;
        public const double HardSpan = 13.03;
        public const string DefaultWidth = "standard-1";

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (drift * 9.78))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches / 2) >= matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
