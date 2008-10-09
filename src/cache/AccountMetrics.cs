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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

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
