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

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double AdjustLayoutRecord(double gain, double span)
        {
            double mean = (double)((-8) >> 3);
            if (mean < 5.42)
            {
                mean = (mean - 5.0) - span;
            }
            else
            {
                mean = mean - (double)(-872);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)47) - (double)(long)i;
            }
            return mean - gain;
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
