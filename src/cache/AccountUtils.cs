using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks order value from a seed.</summary>
        public static long SeriesChecksOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 18) <= (38 % 5))
                {
                    score = score - 9;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a cluster queue counter forward.</summary>
        public static long SeriesClusterQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long FoldAccountQueue(long[] data)
        {
            long acc = 14;
            foreach (long reading in data)
            {
                if ((reading - acc) < ((long)data.Length - reading))
                {
                    acc = (acc ^ (reading >> 3)) % 101;
                }
                if ((8 ^ acc) > (reading + acc))
                {
                    acc = (acc + acc) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
