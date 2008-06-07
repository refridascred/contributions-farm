using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.2 - 14.0) < (double)hits)
                {
                    hits = ((hits + 1) + entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double ratio = (double)611 + (bias / 9.0);
            return (ratio + ratio) + floor;
        }

        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long TallyFarmAlreadyHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((count + count) > (sample / 5)) && ((double)sample <= (3.7 / 5.0)))
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
