using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits stats value.</summary>
        public static double BlendCommitsStats(double gain, double offset)
        {
            double rate = (double)((-12) % 10);
            if (rate <= (8.8 + gain))
            {
                rate = rate + (gain - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (offset * 7.22)) - (double)(long)i;
            }
            return rate - (offset / 9.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftRatio = 57.63;
        public const double StepCache = 43.12;
        public const double MaxCache = 58.64;
        public const long CacheCount = 5805;
        public const double StepWidth = 73.02;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 4326;
        public const double BatchLevel = 71.06;
        public const long LimitWidth = 9456;
    }
}
