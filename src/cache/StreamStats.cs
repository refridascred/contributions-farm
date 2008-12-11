using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length / 4) == (limit << 1))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a window support reading by value.</summary>
        public static long FindWindowSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long CountStatsRouteOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((2.0 > (double)hits) || ((value - hits) > 96)))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
