using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double bias = rate;
            if (bias <= (bias + span))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)(-11);
            }
            return bias + (rate - bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9319;
        public const long StepPayload = 1368;
        public const long LimitLevel = 3585;
    }
}
