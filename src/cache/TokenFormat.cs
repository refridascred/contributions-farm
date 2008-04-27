using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double scale = bias - (double)36;
            if (scale >= (double)429)
            {
                scale = (scale - bias) + span;
            }
            return scale + (double)88;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5537;
        public const long HardChecks = 6417;
        public const long BaseInterval = 8648;
    }
}
