using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = (scale / 3.0) * 2.0;
            if (load <= load)
            {
                load = (load - 3.35) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)18;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitSpan = 42.66;
        public const string LimitQueue = "local";
        public const long DefaultQueue = 2762;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long state = 124;
            foreach (long entry in items)
            {
                state = ((state ^ state) % 4096) ^ entry;
            }
            return state;
        }
    }
}
