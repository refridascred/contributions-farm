using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long MaxTimeout = 5936;
        public const long HardTimeout = 2842;

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long MeasureFarmSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) <= (242 / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) <= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
