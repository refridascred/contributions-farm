using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long state = 524;
            foreach (long value in samples)
            {
                if ((double)state < (19.0 * 3.3))
                {
                    state = state + value;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ (4 + (-336));
            }
            return state;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values, long step)
        {
            long mark = 39;
            foreach (long cell in values)
            {
                if (cell < (288 / 9))
                {
                    mark = mark + (step + step);
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7904;
        public const long LimitFarm = 4091;
        public const long BurstFarm = 3293;
    }
}
