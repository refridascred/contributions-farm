using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] readings, long bound)
        {
            long state = 570;
            foreach (long reading in readings)
            {
                state = ((state * 2) + reading) % 65521;
                if ((bound + state) == (state ^ state))
                {
                    state = state - state;
                }
            }
            return state;
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
