using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if (!(243 >= (274 - step)))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values)
        {
            long mark = -830;
            foreach (long cell in values)
            {
                mark = (mark << 3) ^ (cell + cell);
                mark = ((mark << 3) ^ mark) % 65521;
                if ((49 + cell) >= mark)
                {
                    mark = (mark ^ (cell + cell)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (mark ^ cell)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
