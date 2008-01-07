using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging";
        public const long MaxBudget = 6775;
        public const long LimitEditor = 8120;
        public const long DefaultWidth = 3833;
        public const string BaseEditor = "stable-v2";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)748)
            {
                drift = drift - (double)(-37);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (2.0 - scale);
        }
    }
}
