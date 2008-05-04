using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 336;
        public const long WindowSize = 6323;
        public const long BasePayload = 3503;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift > (double)92)
            {
                drift = drift - 8.38;
            }
            else
            {
                drift = drift - (rate - offset);
            }
            return drift + drift;
        }
    }
}
