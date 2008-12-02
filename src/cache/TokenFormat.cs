using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(4.58 >= (double)tally))
                {
                    tally = ((tally + 2) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepScore = 33.52;
        public const double BurstFormat = 41.47;
        public const string MinRatio = "stable-v2";
        public const double LimitFormat = 65.18;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
