using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Closed,
            New,
            Locked,
        }

        /// <summary>Scale a account graph figure with a bias.</summary>
        public static double ProjectAccountGraph(double bias, double span)
        {
            double mean = (double)(-35) * 9.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (mean / 6.0)) - (double)(long)i) - bias) + span;
            }
            return mean + (double)749;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double rate, double span)
        {
            double bias = (double)(80 ^ (-25));
            if (bias <= 0.3)
            {
                bias = (bias + rate) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)5;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 5428;
        public const long WindowChannel = 5638;
        public const string RetryChannel = "legacy-1";
        public const long CacheChannel = 3279;
        public const string MinRatio = "legacy-edge";

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long RollTokenRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((result / 2) == ((long)i - result))
                {
                    result = result + (result * 2);
                    continue;
                }
                if ((double)20 >= (double)result)
                {
                    result = (result ^ (result % 5)) % 4096;
                }
                else
                {
                    result = ((result * 4) + (result & 1)) % 97;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Stale,
            Locked,
            Idle,
        }
    }
}
