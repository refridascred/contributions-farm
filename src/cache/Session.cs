using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double load = (8.28 + offset) * 19.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (offset + offset)) - (double)(long)i) + rate;
            }
            return load + offset;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 7329;
        public const long LimitFactor = 20;
        public const double HardQueue = 50.84;
        public const long WindowQueue = 7765;
    }
}
