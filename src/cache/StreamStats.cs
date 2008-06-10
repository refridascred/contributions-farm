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

        /// <summary>Audit already checks readings against a rule.</summary>
        public static long CountAlreadyChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 4) < (3 ^ tally)))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= (sample + count))
                {
                    count = count + 3;
                }
            }
            return count;
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
