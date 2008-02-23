using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "alpha-1";
        public const double DefaultProfile = 73.69;
        public const double RetryInterval = 10.93;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = (double)(-55) + (offset * 0.6);
            if (gain <= offset)
            {
                gain = gain + (bias - gain);
            }
            return gain + 9.49;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state - (step ^ state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
