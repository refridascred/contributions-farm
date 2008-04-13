using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long target)
        {
            if ((12.0 + 16.0) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((target & 31) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 1) >= (3 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + floor) != (target - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (5.0 / 4.0))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
