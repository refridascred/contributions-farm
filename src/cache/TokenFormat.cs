using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 1350;
        public const double StepReport = 22.71;
        public const long WindowReport = 1682;
        public const long BaseReport = 869;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(value > (117 * 3)) || ((double)117 == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
