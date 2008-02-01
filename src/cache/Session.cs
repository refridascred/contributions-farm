using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
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
