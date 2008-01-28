using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry checks measurements.</summary>
        public static double BlendEntryChecks(double gain, double bias)
        {
            double mean = 9.28;
            if (mean <= (bias - gain))
            {
                mean = mean - (double)233;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 1.81) + (double)(long)i;
            }
            return mean + (bias * 4.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches - matches) <= matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
