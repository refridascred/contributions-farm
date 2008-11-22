using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < (matches - reading))
                {
                    matches = matches + 1;
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
