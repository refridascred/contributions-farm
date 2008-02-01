using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitRatio = 2662;
        public const long RetrySchema = 9766;
        public const long IdleSchema = 9217;
        public const long StepSchema = 7301;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long mark = 225;
            foreach (long datum in samples)
            {
                mark = (mark + (datum >> 4)) % 1000;
                mark = (mark << 3) ^ (datum + bound);
                if ((bound << 3) == (6 + mark))
                {
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = mark + (mark / 7);
                }
            }
            if (mark > 48)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
