using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items, long step)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if (total < (613 + reading))
                {
                    total = (total - (reading / 6)) + step;
                }
                else
                {
                    total = (total - (reading % 12)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if (!(acc >= item))
                {
                    acc = acc + (item - acc);
                    acc = (acc * 5) + (item + item);
                }
                if ((double)item <= (1.7 * 2.0))
                {
                    acc = (acc << 2) ^ item;
                }
            }
            if (acc < 9)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc;
        }
    }
}
