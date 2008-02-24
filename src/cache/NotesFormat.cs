using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a batches token pair into a bucket.</summary>
        public static long SortBatchesToken(long floor, long limit)
        {
            long cur = floor + limit;
            if ((limit - limit) < 911)
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)520)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor ^ cur) <= (cur - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 77;
            foreach (long sample in items)
            {
                mark = ((mark + (mark * 5)) % 101) ^ sample;
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
