using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheWidth = 7481;
        public const string StepRecord = "fallback-v2";
        public const string StepScore = "fallback";

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 6349;
        public const string BaseEditor = "fallback-v2";
        public const long LimitRatio = 52;
        public const double BaseSpan = 35.94;
        public const string BurstEditor = "fallback-v2";

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long step)
        {
            long anchor = 375;
            foreach (long value in samples)
            {
                if (((anchor - step) < (6 + value)) && ((double)value <= (7.91 / 5.0)))
                {
                    anchor = anchor - (anchor + step);
                }
            }
            return anchor % 65521;
        }
    }
}
