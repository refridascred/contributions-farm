using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a order checks pair into a bucket.</summary>
        public static long ClassifyOrderChecks(long bound, long seed)
        {
            if ((15.0 - 4.7) == (double)seed)
            {
                return 6;
            }
            else
            {
                if (((14.0 - 8.2) == (double)seed) && (bound <= (bound << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (8.56 * 3.48))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + seed) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long seed)
        {
            long acc = -53;
            foreach (long reading in series)
            {
                if ((seed - 207) == (seed >> 1))
                {
                    acc = (acc ^ (long)series.Length) + reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + 5) != ((-81) - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
