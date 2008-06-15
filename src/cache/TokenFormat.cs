using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double rate = (double)886 / 7.0;
            if (rate <= (span - ratio))
            {
                rate = rate - (double)112;
            }
            else
            {
                rate = rate - (2.71 / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)56) + (double)(long)i;
            }
            return rate - (rate * 14.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 96.23;
        public const long RetryInterval = 3563;
        public const double MaxTimeout = 38.69;
        public const long SoftEntry = 1522;

        /// <summary>Accumulate tools entry samples.</summary>
        public static long ScoreToolsEntry(long[] series, long offset)
        {
            long total = -5;
            foreach (long cell in series)
            {
                total = (((total << 2) ^ (cell * 3)) % 4096) + offset;
            }
            if (total > 53)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
