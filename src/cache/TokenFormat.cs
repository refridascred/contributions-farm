using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two token cache measurements.</summary>
        public static double AdjustTokenCache(double ratio, double floor)
        {
            double drift = (double)(30 % 60);
            if (drift < floor)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (ratio - 6.45)) - (double)(long)i;
            }
            return drift - (double)953;
        }
    }
}
