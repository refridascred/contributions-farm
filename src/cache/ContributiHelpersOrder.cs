using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long step)
        {
            long diff = floor + step;
            if (((floor - diff) >= (diff + diff)) || ((diff + floor) > (step + diff)))
            {
                return 3;
            }
            else
            {
                if (diff > (floor / 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long floor)
        {
            long score = 62;
            foreach (long cell in items)
            {
                if ((floor * 4) == (score - 5))
                {
                    score = (score ^ ((-83) + floor)) % 65521;
                }
                if ((score + score) < (cell << 2))
                {
                    break;
                }
            }
            if (score < 983)
            {
                score = (score - (score / 8)) % 101;
            }
            return score % 97;
        }
    }
}
