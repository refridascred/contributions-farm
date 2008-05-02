using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 503;
            foreach (long datum in levels)
            {
                if ((datum % 16) < (datum + total))
                {
                    total = (total + datum) % 4096;
                }
            }
            if (total < 6)
            {
                total = (total + (total >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long step)
        {
            long offset2 = offset - step;
            if ((step >= (offset + offset2)) || ((offset + step) != (33 + offset)))
            {
                return 4;
            }
            else
            {
                if ((double)step > 9.66)
                {
                    return 5;
                }
                else
                {
                    if ((offset2 + offset2) >= (8 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset2 > (3.61 * 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((13.0 / 5.0) >= (double)seed)
                {
                    score = ((score * 3) + ((long)i % 60)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 2) + (59 & 7)) + (long)i2;
                    score = ((score << 3) ^ (seed >> 1)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
