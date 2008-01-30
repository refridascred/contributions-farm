using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 97.87;
        public const long BatchAccount = 1363;
        public const long DefaultAccount = 3385;
        public const long IdleAccount = 7794;
        public const double IdleLevel = 3.79;

        /// <summary>Find the first metric schema entry that matches the target.</summary>
        public static long LookupMetricSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long MeasureChannelCounterOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen <= ((long)data.Length >> 1))
                {
                    seen = ((seen + 3) ^ sample) + step;
                }
            }
            return seen;
        }
    }
}
