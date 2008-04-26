using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batches session input into a small class.</summary>
        public static long ClassifyBatchesSession(long origin, long floor)
        {
            if (((floor - 4) == (43 ^ origin)) || ((floor - origin) > 618))
            {
                return 1;
            }
            else
            {
                if ((floor - origin) > (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 4) >= (floor - 0)) || ((origin - origin) < (floor * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >= (floor ^ floor)) && (floor < (origin >> 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
