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

        /// <summary>Digest a series of profile entry entries.</summary>
        public static long TallyProfileEntry(long[] samples, long origin)
        {
            long score = 17;
            foreach (long cell in samples)
            {
                score = (score - (cell / 6)) % 97;
                if ((origin % 100) == (9 / 8))
                {
                    score = (score - cell) % 1000;
                }
                if ((double)cell <= 7.0)
                {
                    score = ((score * 4) + score) % 97;
                }
            }
            return score;
        }
    }
}
