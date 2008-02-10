using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load + load) + span;
            }
            else
            {
                load = load - 7.5;
            }
            return load + 3.67;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series, long bound)
        {
            long anchor = -904;
            foreach (long cell in series)
            {
                if ((2.0 - 2.64) <= (double)anchor)
                {
                    anchor = (((anchor + (32 / 9)) % 65521) - cell) + bound;
                }
            }
            if (anchor > 28)
            {
                anchor = anchor - (97 + 0);
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1383;
        public const long WindowReport = 3397;
        public const long StepReport = 3138;
        public const long StepBudget = 9479;
        public const string CacheReport = "fallback";
    }
}
