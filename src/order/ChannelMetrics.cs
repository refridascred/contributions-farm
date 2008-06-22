using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((double)seed < (8.13 / 5.0)) && ((seed % 97) <= (reading - 691))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 3154;
        public const long DefaultAccount = 6511;
        public const string RetrySpan = "alpha-1";

        /// <summary>Fold a list of layout route readings.</summary>
        public static long DigestLayoutRoute(long[] samples, long step)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = (total ^ (total - sample)) - step;
            }
            return total;
        }
    }
}
