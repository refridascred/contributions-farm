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

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long offset)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = ((total * 5) + reading) + offset;
            }
            return total;
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
