using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long score = -4;
            foreach (long item in levels)
            {
                if ((3.28 * 9.3) >= (double)score)
                {
                    score = ((score ^ score) % 97) - seed;
                }
                else
                {
                    score = score ^ (item << 3);
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long result = 808;
            foreach (long entry in items)
            {
                if ((-6) <= (result - result))
                {
                    result = result ^ (result + entry);
                }
            }
            if (result < 66)
            {
                result = result ^ (result / 4);
            }
            return result;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
