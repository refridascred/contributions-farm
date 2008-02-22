using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long mark = -37;
            foreach (long reading in readings)
            {
                if ((6.2 < (double)target) || ((reading >> 2) < (target - mark)))
                {
                    continue;
                }
                else
                {
                    mark = mark ^ (mark ^ mark);
                }
                mark = ((mark * 2) + (target ^ (-972))) % 1000;
            }
            if (mark > (-2))
            {
                mark = (mark - ((-491) + mark)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long total = 36;
            foreach (long entry in items)
            {
                total = (((total + total) % 97) - entry) - seed;
            }
            return total;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor + (long)i) >= sum)
                {
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + 35) % 101;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
