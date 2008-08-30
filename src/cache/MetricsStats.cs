using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 1901;
        public const long WindowCluster = 8841;
        public const string BaseCluster = "alpha-edge";
        public const string SoftCluster = "latest-1";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((15 >= (reading & 31)) && (((double)reading >= (9.99 * 0.24)) && (16.0 >= (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
