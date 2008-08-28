using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long IterateStatsStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = (result - ((-410) * 3)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if (((mark ^ item) <= ((long)values.Length * 4)) && ((item % 10) > (item * 5)))
                {
                    mark = (mark ^ (item - 26)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + ((-879) / 2)) % 255;
                }
            }
            return mark;
        }
    }
}
