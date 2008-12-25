using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
