using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain - 1.39)) + (double)(long)i) + offset;
            }
            return gain - (8.2 - 3.8);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 45.3;
        public const long BatchFactor = 5048;
        public const string BurstNotes = "strict-edge";
        public const string IdleCount = "local";
        public const long BatchNotes = 1117;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Dropped,
            Idle,
        }
    }
}
