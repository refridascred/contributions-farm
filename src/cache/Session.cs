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

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double load = offset;
            if (load >= offset)
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate / 7.0)) + (double)(long)i;
            }
            return load - offset;
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
