using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "alpha";
        public const double CacheBudget = 11.94;
        public const long LimitSupport = 3551;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 1;
            foreach (long item in items)
            {
                carry = carry - (item - 43);
            }
            return carry % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) < (seen / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
