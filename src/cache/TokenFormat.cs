using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long offset, long seed)
        {
            if ((double)offset <= (2.8 - 5.0))
            {
                return 3;
            }
            else
            {
                if (!((seed % 24) >= offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long state = 435;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ (state % 8)) + datum;
                state = (state + (state % 10)) % 4096;
            }
            return state;
        }
    }
}
