using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long origin)
        {
            if (742 > (origin + seed))
            {
                return 7;
            }
            else
            {
                if ((origin / 3) == (676 + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-edge";
        public const long LimitPayload = 3251;
        public const string MinPayload = "cached-edge";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = (gain - bias) * 2.33;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (double)14;
        }
    }
}
