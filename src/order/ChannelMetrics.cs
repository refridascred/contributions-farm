using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if ((sample ^ result) < sample)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 28.75;
        public const double WindowBudget = 58.76;
        public const long SoftLevel = 7221;
        public const long IdleLevel = 1497;
        public const double IdleRecord = 33.45;
    }
}
