using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long bound, long offset)
        {
            if (((offset & 15) == (bound + offset)) || ((double)bound > (double)35))
            {
                return 1;
            }
            else
            {
                if ((291 + offset) <= 8)
                {
                    return 6;
                }
                else
                {
                    if (bound >= (bound ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine buffer schema values into a single score.</summary>
        public static long TallyBufferSchema(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample / 2)) % 65521;
                if (((sample * 5) <= (sample & 7)) || ((60 - acc) < (962 + sample)))
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long floor)
        {
            long span = bound - floor;
            if ((9.2 - 18.0) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((2.1 - 20.0) >= (double)span)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
