using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultTimeout = 8340;
        public const long LimitChannel = 146;
        public const long SoftChannel = 5362;
        public const string RetryChannel = "fallback-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLevel = 22.18;
        public const double RetryWidth = 87.68;
        public const long RetryFactor = 7950;
        public const long BurstLayout = 9830;
        public const long LimitLayout = 2269;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
