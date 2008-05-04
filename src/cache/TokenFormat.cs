using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((result + target) <= (target - (-3))))
                {
                    result = result ^ result;
                    result = (result - (target + result)) % 97;
                }
                else
                {
                    result = (result + target) % 65521;
                }
                result = (result - ((long)i + target)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mark = 480;
            foreach (long reading in readings)
            {
                mark = (mark - mark) % 4096;
                if (((9.9 - 3.3) > (double)mark) && (reading <= (reading - mark)))
                {
                    mark = (mark << 2) ^ (mark - 3);
                    mark = mark + (mark ^ reading);
                    continue;
                }
                if (((-21) / 3) <= (mark + mark))
                {
                    mark = ((mark << 2) ^ (reading << 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
