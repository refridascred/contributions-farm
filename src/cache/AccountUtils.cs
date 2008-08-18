using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 29.34;
        public const long LimitCount = 3237;
        public const long BaseQueue = 1006;
        public const long RetryLevel = 911;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitScore = 52.04;
        public const double DefaultContext = 96.09;
        public const double BaseContext = 29.59;
        public const long CacheFactor = 3508;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >= (reading / 8)) || ((reading >> 3) < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
