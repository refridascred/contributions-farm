using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double gain = (double)79 - span;
            if (gain >= (gain * 4.0))
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)709;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
