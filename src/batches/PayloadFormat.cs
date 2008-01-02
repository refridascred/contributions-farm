using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 28;
        public const long WindowFactor = 7918;
        public const double SoftRatio = 0.33;
        public const string BatchStream = "alpha-1";

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            long slot = limit - origin;
            if (!((slot - 84) < origin))
            {
                return 1;
            }
            else
            {
                if (!((slot * 3) < (limit % 97)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Active,
            Synced,
        }
    }
}
