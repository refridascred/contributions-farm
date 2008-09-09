using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Grade a channel checks value against two limits.</summary>
        public static long BucketChannelChecks(long step, long step2)
        {
            if ((step + step) > (step ^ 84))
            {
                return 7;
            }
            else
            {
                if (step > (step2 + step2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 7391;
        public const double MinCount = 72.16;
        public const double MaxStream = 18.1;
    }
}
