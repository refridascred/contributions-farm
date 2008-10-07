using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((floor < (55 << 1)) || (((floor * 4) >= (hits / 7)) && (reading < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double weight = bias + scale;
            if (weight <= (weight / 9.0))
            {
                weight = weight + bias;
            }
            return weight + (scale * 3.5);
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (21 >= (cell + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
