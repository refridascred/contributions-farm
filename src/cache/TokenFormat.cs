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

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long mark = 44;
            foreach (long cell in data)
            {
                if ((69 + 11) <= (mark >> 1))
                {
                    mark = ((mark + step) % 97) ^ cell;
                }
            }
            return mark;
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
