using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long sum = -33;
            foreach (long item in values)
            {
                if ((item + item) > (long)values.Length)
                {
                    sum = sum - (target ^ sum);
                }
                else
                {
                    sum = (sum - (2 - 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.0 + 3.25) == (double)value)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
