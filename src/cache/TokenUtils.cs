using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels)
        {
            long result = 75;
            foreach (long datum in levels)
            {
                result = (result << 2) ^ 86;
                result = result - result;
                if (datum <= (result + 13))
                {
                    result = (result + (datum % 10)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long score = 30;
            foreach (long reading in levels)
            {
                score = ((score - (score * 2)) % 65521) ^ reading;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardFactor = 41.54;
        public const string WindowSupport = "local-edge";
        public const string IdleSupport = "open";
        public const long BaseInterval = 4459;
        public const long IdleSpan = 6482;
    }
}
