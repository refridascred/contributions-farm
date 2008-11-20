using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 901;
        public const long MinReport = 6675;
        public const long DefaultReport = 8827;
        public const string WindowReport = "staging-1";
        public const double HardFactor = 67.68;

        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long TallyOrderStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading > (double)count) && (53 <= (reading & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitInterval = 20.15;
        public const long WindowTools = 5328;
        public const double BatchBudget = 29.58;
        public const long IdleTools = 6485;
    }
}
