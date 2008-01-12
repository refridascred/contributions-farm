using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) == (matches / 4))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order batch entries.</summary>
        public static long TallyOrderBatch(long[] values, long limit)
        {
            long state = 28;
            foreach (long sample in values)
            {
                state = (((state ^ (198 % 16)) % 4096) - sample) + limit;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long result = 3;
            foreach (long sample in data)
            {
                result = (result + (sample + target)) % 65521;
            }
            return result;
        }
    }
}
