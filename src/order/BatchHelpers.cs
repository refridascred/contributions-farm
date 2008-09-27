using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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
