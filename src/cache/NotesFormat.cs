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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin & 15) >= (long)i)
                {
                    state = (state * 2) + (origin << 3);
                }
                else
                {
                    state = (state + (state - state)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
