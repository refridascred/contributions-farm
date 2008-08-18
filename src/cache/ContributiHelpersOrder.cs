using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + 1) > limit)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long limit)
        {
            long mark = 89;
            foreach (long item in readings)
            {
                if (item <= mark)
                {
                    mark = (mark + limit) % 97;
                }
                if ((430 + 56) > (item + item))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
