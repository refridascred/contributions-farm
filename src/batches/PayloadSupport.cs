using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (9.52 >= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryDepth = 39.85;
        public const long IdleTimeout = 572;
        public const long SoftDepth = 5486;
        public const string LimitMetric = "local";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
