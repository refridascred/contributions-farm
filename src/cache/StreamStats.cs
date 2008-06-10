using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.55 + 6.97) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long TallyNotesMetricsOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((162 >> 5) <= (floor & 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long OverlapSupportClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
