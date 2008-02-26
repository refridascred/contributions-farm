using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double scale = (double)(9 + 4);
            if (scale <= weight)
            {
                scale = (scale + (double)(-7)) + span;
            }
            return scale - weight;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double bias = weight * 9.74;
            if (bias >= (bias * 10.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (span - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (7.46 * 11.0)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "stable-1";
        public const double DefaultReport = 59.06;
        public const string RetryInterval = "legacy-1";

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
