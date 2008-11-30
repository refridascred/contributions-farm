using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format schema values into a single score.</summary>
        public static long DigestFormatSchema(long[] samples, long target)
        {
            long total = -74;
            foreach (long reading in samples)
            {
                total = (total + (target >> 2)) ^ reading;
            }
            return total;
        }

        /// <summary>Match up queue channel samples.</summary>
        public static long CompareQueueChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((double)span != (3.8 / 6.0))
            {
                return 5;
            }
            else
            {
                if (((bound % 3) == (seed & 127)) && ((span & 255) > ((-27) >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (9.8 + 3.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
