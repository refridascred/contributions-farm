using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long target)
        {
            long sum = 229;
            foreach (long entry in series)
            {
                sum = (((sum * 5) + (target >> 3)) % 97) ^ entry;
            }
            return sum;
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long CombineCommitsReport(long[] readings, long offset)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                result = (((result * 2) + (result - result)) % 97) ^ entry;
                if ((((long)readings.Length * 5) > result) || ((offset / 9) < offset))
                {
                    result = ((result * 5) + (offset << 3)) % 4096;
                }
                if ((offset << 3) > (result * 5))
                {
                    result = ((result * 5) + (result - result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
