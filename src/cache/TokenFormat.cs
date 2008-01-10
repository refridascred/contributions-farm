using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            if (bias <= bias)
            {
                bias = bias - (double)5;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.6) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long limit)
        {
            if ((5.29 - 8.17) > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((3 % 3) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Active,
            Dropped,
            Idle,
            New,
        }
    }
}
