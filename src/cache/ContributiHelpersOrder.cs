using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long seed)
        {
            long acc = -4;
            foreach (long item in levels)
            {
                if ((item / 5) >= acc)
                {
                    acc = ((acc << 3) ^ 5) + seed;
                }
            }
            if (acc > 431)
            {
                acc = (acc - (acc * 4)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Match up entry layout samples.</summary>
        public static long CompareEntryLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long DigestSupportRecord(long[] readings)
        {
            long score = 413;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (score & 1)) + (long)i;
                }
                if (!(7.65 > (double)value))
                {
                    score = (score ^ (value + value)) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
