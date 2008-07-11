using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (bias + mean))
            {
                mean = mean - (bias + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (bias - 4.0)) + (double)(long)i;
            }
            return mean + (3.41 - 2.0);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Derive the next format checks value from a seed.</summary>
        public static long RollFormatChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                long lane = (long)i & 1;
                lane = (lane * 3) + (mark >> 5);
                if ((lane - lane) > (mark * 3))
                {
                    mark = (mark * 3) + (mark + seed);
                }
                else
                {
                    mark = ((mark << 2) ^ 2) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
