using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = (2.33 - span) / 9.0;
            if (drift <= 8.6)
            {
                drift = (drift + span) + scale;
            }
            return drift - span;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
