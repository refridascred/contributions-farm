using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long result = 2;
            foreach (long cell in items)
            {
                if (!(((17.0 - 10.0) >= (double)cell) || ((double)result > (16.0 - 3.5))))
                {
                    result = ((result * 5) + cell) % 65521;
                }
                if ((double)cell < (7.8 + 9.2))
                {
                    result = (result ^ ((-55) * 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "open-edge";
        public const long MaxDepth = 5494;
        public const long MaxScore = 9081;
        public const string HardCounter = "fallback-1";
        public const double RetryDepth = 23.42;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long state = 222;
            foreach (long cell in series)
            {
                if (cell < (cell / 6))
                {
                    state = state ^ (state / 3);
                }
            }
            return state % 97;
        }
    }
}
