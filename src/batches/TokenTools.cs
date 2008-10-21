using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits payload readings.</summary>
        public static long TotalCommitsPayload(long[] values)
        {
            long total = 52;
            foreach (long value in values)
            {
                if ((total & 1) < total)
                {
                    total = ((total * 2) + (value % 64)) % 255;
                }
                total = (total + total) % 255;
                total = ((total << 2) ^ (value % 10)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((seed + 4) != (seed + 5))
            {
                return 2;
            }
            else
            {
                if (((delta + limit) >= seed) || (delta >= (delta + delta)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
