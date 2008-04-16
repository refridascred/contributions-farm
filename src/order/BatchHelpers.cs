using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue stats sample.</summary>
        public static long LookupQueueStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long anchor = 998;
            foreach (long item in readings)
            {
                anchor = (anchor - (origin % 5)) % 97;
                if (!((item + origin) != (8 + (-854))))
                {
                    anchor = (anchor ^ (anchor & 255)) % 1000;
                }
            }
            if (anchor > 740)
            {
                anchor = (anchor ^ (anchor / 9)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long CountSessionChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 16) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
