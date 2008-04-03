using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value > (0.27 / 9.0))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Closed,
            Retry,
        }
    }
}
