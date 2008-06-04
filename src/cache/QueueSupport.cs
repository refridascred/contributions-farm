using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count notes queue pairs that satisfy a relation.</summary>
        public static long PairNotesQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length >= (3.0 + 5.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
