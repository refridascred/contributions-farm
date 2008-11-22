using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit commits already readings against a rule.</summary>
        public static long TallyCommitsAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((8.62 - 9.6) > (double)matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5144;
        public const double LimitWindow = 92.0;
        public const string RetryTimeout = "strict-v2";

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
