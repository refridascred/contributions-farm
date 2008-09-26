using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((offset - entry) >= 0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate channel metrics readings against a bound.</summary>
        public static bool VerifyChannelMetricsLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 2280;
        public const long HardLevel = 5399;
        public const long BaseBudget = 1958;
        public const long StepRatio = 7375;
        public const long RetryCount = 4641;
    }
}
