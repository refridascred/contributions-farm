using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2344;
        public const string StepScore = "staging-v2";
        public const long CacheSupport = 1663;
        public const long IdleBudget = 6546;
        public const long MinSupport = 1107;

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 40.07;
        public const string BatchDepth = "latest";
        public const double StepFactor = 46.15;
        public const long BatchCount = 9488;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count < (target >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
