using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command already counter forward.</summary>
        public static long SeriesCommandAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + bound) % 1000;
                if (!(bound <= anchor))
                {
                    anchor = (anchor + (bound >> 5)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Queued,
            Active,
            Done,
            Retry,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double drift = (double)0 / 7.0;
            if (drift > bias2)
            {
                drift = (drift - bias2) - bias;
            }
            return drift + (drift + drift);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
