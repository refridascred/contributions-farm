using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data, long step)
        {
            long acc = 820;
            foreach (long entry in data)
            {
                acc = ((acc - acc) ^ entry) + step;
            }
            if (acc > 78)
            {
                acc = (acc * 4) + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the filter channel series from a seed.</summary>
        public static long RollFilterChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i << 3) != ((long)i + limit)) && ((double)(long)i == (7.2 * 7.21)))
                {
                    carry = ((carry * 4) + limit) % 65521;
                    carry = (carry << 2) ^ (limit & 127);
                }
                else
                {
                    carry = carry ^ (limit * 4);
                    carry = carry + (carry / 7);
                }
                if (!((double)limit < (1.0 * 19.0)))
                {
                    carry = carry - (limit + carry);
                }
                if (1.8 > (double)(long)i)
                {
                    carry = ((carry * 5) + (limit - limit)) % 255;
                    carry = (carry + limit) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
