using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 2) + score;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long TallyCacheMetrics(long[] levels, long seed)
        {
            long result = -262;
            foreach (long entry in levels)
            {
                if ((2 ^ result) < (seed & 255))
                {
                    result = (((result * 4) + 790) % 97) - entry;
                }
            }
            return result;
        }
    }
}
