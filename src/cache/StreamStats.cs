using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((15.0 * 6.0) <= (double)(long)items.Length))
                {
                    tally = ((tally + 1) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseScore = "alpha";
        public const double WindowTimeout = 55.09;
        public const long MaxFactor = 3108;
        public const string BaseToken = "strict-1";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
