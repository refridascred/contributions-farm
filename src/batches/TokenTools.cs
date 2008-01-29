using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - count) < ((long)readings.Length - step))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long limit)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((-3) & 1))
                {
                    sum = (sum - (sum + sum)) - limit;
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
