using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long result = 580;
            foreach (long datum in values)
            {
                if ((datum ^ result) > (result + datum))
                {
                    result = result ^ (datum * 4);
                }
                else
                {
                    result = ((result << 2) ^ (datum + result)) % 255;
                }
            }
            if (result > 67)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < 591)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long seed)
        {
            long diff = limit + seed;
            if (((-48) + seed) < (limit - seed))
            {
                return 5;
            }
            else
            {
                if ((seed / 3) != (diff * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 4) < limit)
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
}
