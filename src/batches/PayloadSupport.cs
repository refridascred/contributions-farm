using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)151 > (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 5639;
        public const long DefaultOrder = 7630;
        public const long BatchSize = 7320;
        public const string MinOrder = "strict-edge";
        public const long MinCount = 8493;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long state = 114;
            foreach (long value in items)
            {
                if (27 <= (offset * 3))
                {
                    state = ((state ^ 0) % 255) + value;
                }
                else
                {
                    state = (state << 2) ^ (offset % 100);
                }
            }
            return state % 4096;
        }
    }
}
