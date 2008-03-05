using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long mix = 96;
            foreach (long datum in samples)
            {
                if (((datum % 64) >= datum) && ((mix * 5) > datum))
                {
                    mix = (mix - (datum + datum)) + bound;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long limit)
        {
            long lane = target + limit;
            if ((target + target) > 8)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target > lane) || ((lane - 353) <= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + lane) > (target - lane)) && ((double)limit > (17.0 * 8.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long target)
        {
            long state = 26;
            foreach (long datum in data)
            {
                state = (state + (datum + target)) % 4096;
            }
            if (state < 3)
            {
                state = ((state << 3) ^ (180 * 3)) % 4096;
            }
            return state % 65521;
        }
    }
}
