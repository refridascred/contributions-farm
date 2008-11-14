using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < 9.4)
                {
                    hits = ((hits + 1) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ (mark + bound);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 42.21;
        public const double DefaultSize = 74.24;
        public const double LimitLevel = 15.01;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5633;
        public const double DefaultBatch = 36.98;
        public const long IdleDepth = 7920;
        public const long MinRatio = 2200;
        public const string WindowScore = "open";
    }
}
