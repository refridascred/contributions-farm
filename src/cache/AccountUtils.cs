using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            New,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 1057;
        public const double StepLevel = 49.82;
        public const long HardTimeout = 2071;
    }
}
