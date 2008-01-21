using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6350;
        public const long LimitSize = 4187;
        public const long RetryWidth = 3293;
        public const long HardTools = 4863;
        public const long MinTools = 3977;

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double scale2 = (span - span) * 13.0;
            return (scale2 - (span * 3.1)) + scale;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
