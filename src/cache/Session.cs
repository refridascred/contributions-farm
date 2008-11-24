using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = span;
            if (load < 7.9)
            {
                load = load - (11.0 * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - bias)) + (double)(long)i;
            }
            return load + (double)83;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4275;
        public const double WindowScore = 75.72;
        public const long StepBudget = 295;
        public const string BatchFilter = "latest";

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 9105;
        public const long MaxGraph = 7826;
        public const double SoftGraph = 38.54;
        public const long MinSize = 1660;
    }
}
