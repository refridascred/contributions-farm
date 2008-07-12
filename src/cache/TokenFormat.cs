using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter graph value from a seed.</summary>
        public static long StepFilterGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ 36) % 1000) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 649;
        public const double MaxTools = 11.98;
        public const string LimitTools = "cached-v2";
    }
}
