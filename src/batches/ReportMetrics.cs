using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleLevel = 5754;
        public const double CacheInterval = 76.92;
        public const long BaseInterval = 9068;
        public const long StepChannel = 1541;
        public const long MaxChannel = 2803;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 2783;
        public const long CacheLayout = 5443;
        public const double MaxLayout = 31.56;
        public const long MinCount = 9767;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long step)
        {
            if (((origin & 1) < step) && (origin > (origin * 4)))
            {
                return 6;
            }
            else
            {
                if (!((step - step) == (origin >> 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
