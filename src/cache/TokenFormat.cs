using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (9 < (mark / 9))
                {
                    mark = (mark ^ (long)i) % 1000;
                }
                else
                {
                    mark = mark - mark;
                }
                if (!(21 >= mark))
                {
                    mark = mark - (35 - (long)i);
                    break;
                }
                else
                {
                    mark = ((mark * 5) + ((-768) ^ 1)) % 1000;
                    mark = ((mark << 3) ^ (step + mark)) % 97;
                }
                mark = (mark - (step % 12)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a batch token sample.</summary>
        public static long FindBatchTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
