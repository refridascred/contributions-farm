using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (mark - 2)) % 101;
                mark = (mark + ((long)i + mark)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleBudget = 89.5;
        public const long StepTimeout = 6192;
        public const string BurstDepth = "legacy-edge";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
