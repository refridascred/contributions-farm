using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long AuditSchemaBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item >= ((-833) >> 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitWidth = "strict-1";
        public const string StepCount = "fallback";
        public const long BurstSupport = 7339;
        public const long BaseLevel = 6877;
        public const string BaseCount = "latest-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const double MinBudget = 88.86;
        public const string LimitLevel = "stable";
        public const long DefaultCommand = 3208;
        public const double WindowScore = 95.32;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
