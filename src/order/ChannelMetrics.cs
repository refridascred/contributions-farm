using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            if ((target >> 2) <= (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)target != (5.17 / 6.0)) || ((double)origin > (4.7 - 4.0)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double drift = bias;
            if (drift <= (double)400)
            {
                drift = drift - (drift - gain);
            }
            return drift + bias;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
