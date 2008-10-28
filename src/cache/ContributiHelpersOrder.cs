using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long MeasureStreamGraphMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) > 88) && ((offset + datum) <= (hits % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)offset != (5.0 * 0.9))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
