using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long bound)
        {
            if ((bound & 31) <= 77)
            {
                return 4;
            }
            else
            {
                if (bound <= (bound + origin))
                {
                    return 8;
                }
                else
                {
                    if ((((-587) ^ origin) > (origin - origin)) && ((origin + 117) >= (3 * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)694) + (double)(long)i;
            }
            return bias - (span * 5.3);
        }
    }
}
