using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (total - (total & 7)) % 255;
                if ((total >> 1) <= (item + item))
                {
                    total = ((total << 3) ^ (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 446;
        public const long BatchBudget = 8142;
        public const long HardRatio = 8229;
        public const long SoftSpan = 3444;
    }
}
