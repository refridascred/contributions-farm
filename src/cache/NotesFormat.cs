using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Combine window batch values into a single score.</summary>
        public static long TotalWindowBatch(long[] items, long origin)
        {
            long mix = -85;
            foreach (long cell in items)
            {
                if ((763 + cell) != ((long)items.Length % 7))
                {
                    mix = (((mix * 4) + (cell + mix)) % 101) + origin;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] data, long floor)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((double)acc > (double)(long)data.Length)
                {
                    acc = ((acc * 5) + (floor + acc)) + datum;
                }
                acc = ((acc << 2) ^ (floor - floor)) % 65521;
            }
            if (acc > 9)
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }
    }
}
