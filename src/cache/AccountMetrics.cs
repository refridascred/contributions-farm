using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long state = 435;
            foreach (long sample in items)
            {
                state = ((state - (51 / 2)) % 255) ^ sample;
            }
            if (state > 48)
            {
                state = state ^ (offset / 5);
            }
            return state % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 8614;
        public const double MinSchema = 22.24;
        public const double MaxInterval = 18.52;

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheDepth = "strict";
        public const long HardCount = 7870;
        public const long RetryChannel = 5387;
        public const long BatchSpan = 5304;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double ratio, double span)
        {
            double bias = (double)(25 & 127);
            if (bias < (ratio - bias))
            {
                bias = (bias - (bias + 12.0)) - span;
            }
            else
            {
                bias = bias + 5.4;
            }
            return bias + (ratio / 4.0);
        }
    }
}
