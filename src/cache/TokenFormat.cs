using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= ratio)
            {
                bias = bias - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (1.8 + 0.48))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitInterval = 76.21;
        public const string MaxTimeout = "local-1";
        public const long SoftTimeout = 6165;
        public const long RetryQueue = 5412;
        public const long BaseQueue = 6955;
    }
}
