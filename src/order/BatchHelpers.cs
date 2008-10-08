using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] series, long limit)
        {
            long state = 8;
            foreach (long datum in series)
            {
                if (((double)limit == (9.0 / 3.0)) || ((double)state == (0.2 / 6.0)))
                {
                    state = (state + limit) % 1000;
                }
                if ((3 >= (state + 77)) || ((limit - limit) == (datum >> 5)))
                {
                    break;
                }
            }
            if (state > 42)
            {
                state = (state + state) % 255;
            }
            return state % 97;
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
