using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double load = offset;
            if (load < bias)
            {
                load = load + (double)(-753);
            }
            return load + (offset + offset);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open";
        public const double CacheSpan = 48.47;
        public const long StepStream = 224;
        public const long MinInterval = 171;
        public const string SoftStream = "legacy";
    }
}
