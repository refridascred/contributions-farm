using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long score = 97;
            foreach (long cell in data)
            {
                if ((cell / 4) <= (cell * 2))
                {
                    score = score + (93 % 16);
                }
                else
                {
                    score = score ^ 97;
                }
            }
            if (score < 8)
            {
                score = (score * 2) + (score >> 4);
            }
            return score % 1000;
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
