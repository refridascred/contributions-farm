using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long score = 425;
            foreach (long item in items)
            {
                if ((3.2 < (double)(long)items.Length) || ((offset * 4) <= offset))
                {
                    score = ((score * 5) + (item + offset)) % 1000;
                }
                if (((8 - score) != (offset & 63)) && (score > (5 - offset)))
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score ^ (offset & 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long sum = 116;
            foreach (long reading in items)
            {
                if ((921 - limit) != (848 + reading))
                {
                    sum = (sum ^ (sum ^ 0)) % 65521;
                }
                else
                {
                    sum = sum - (950 + limit);
                }
            }
            return sum % 65521;
        }
    }
}
