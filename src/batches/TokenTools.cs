using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryWidth = 6730;
        public const long StepGraph = 6381;
        public const double HardGraph = 66.78;
        public const double BatchGraph = 92.53;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double load = floor - gain;
            if (load < gain)
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
