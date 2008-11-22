using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + (-324)) != (tally ^ cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
