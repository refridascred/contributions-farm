using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LookupRouteCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = (weight - 1.19) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally == (20.0 / 9.0))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
