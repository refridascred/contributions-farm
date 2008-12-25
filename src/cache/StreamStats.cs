using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 7132;
        public const long WindowContext = 2015;
        public const string DefaultCount = "primary-1";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2845;
        public const long MaxContext = 7025;
        public const long BaseContext = 6147;
        public const double MinContext = 18.0;
        public const long BaseRatio = 9694;
    }
}
