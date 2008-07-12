using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample % 10) <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
