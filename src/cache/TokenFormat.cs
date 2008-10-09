using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            if ((limit >> 4) >= (limit * 2))
            {
                return 1;
            }
            else
            {
                if (!((bound - limit) <= (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)8 == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit + bound) > limit) && (limit >= (limit % 64)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long mix = 426;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix - 623) ^ (long)i;
                }
                if (59 < (entry + 793))
                {
                    mix = (mix * 4) + (2 * 3);
                }
                else
                {
                    mix = (mix << 3) ^ (seed + mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value / 9) == (483 * 2)) && ((value - count) != (value ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
