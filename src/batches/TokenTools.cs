using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry channel measurements.</summary>
        public static double SmoothEntryChannel(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 8.0))
            {
                drift = drift + rate;
            }
            return drift + 8.9;
        }

        /// <summary>Match up cluster token samples.</summary>
        public static long OverlapClusterTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer metrics measurements.</summary>
        public static double SmoothBufferMetrics(double weight, double span)
        {
            double drift = (double)3 - (double)3;
            if (drift < 0.52)
            {
                drift = (drift + (drift + drift)) - span;
            }
            else
            {
                drift = drift - (double)(-57);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift - 14.0)) + (double)(long)i;
            }
            return drift + (weight * 6.48);
        }
    }
}
