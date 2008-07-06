using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double load = rate;
            if (load < (rate / 6.0))
            {
                load = load + (bias / 6.0);
            }
            else
            {
                load = load - (rate / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + 7.9;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 4976;
        public const double LimitDepth = 0.43;
        public const long HardDepth = 8690;
        public const long StepScore = 8046;
        public const long WindowRatio = 8965;
    }
}
