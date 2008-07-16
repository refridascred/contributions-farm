using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values, long step)
        {
            long score = 201;
            foreach (long entry in values)
            {
                if ((6.4 * 6.0) < (double)step)
                {
                    score = (score * 2) + entry;
                }
                if (((entry << 3) <= (256 + 101)) || ((7.51 + 1.8) != (double)(long)values.Length))
                {
                    break;
                }
            }
            if (score > 199)
            {
                score = score ^ 14;
            }
            return score % 4096;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
