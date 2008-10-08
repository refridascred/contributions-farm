using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long floor)
        {
            if (((target - (-67)) > floor) || ((double)target != (double)floor))
            {
                return 3;
            }
            else
            {
                if (((floor % 2) > (floor / 5)) && ((target ^ target) == (target % 64)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items, long seed)
        {
            long result = -85;
            foreach (long value in items)
            {
                if ((821 + 3) < (value << 2))
                {
                    result = (result << 2) ^ seed;
                }
                result = ((result * 4) + ((long)items.Length + result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
