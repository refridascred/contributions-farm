using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 4723;
        public const long MinCount = 6005;
        public const long WindowRatio = 4904;

        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long SortPayloadFormat(long offset, long seed)
        {
            if (!((double)9 != (double)offset))
            {
                return 8;
            }
            else
            {
                if (!(offset > (seed & 15)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank account filter input into a small class.</summary>
        public static long ClassifyAccountFilter(long bound, long offset)
        {
            if ((6.0 / 8.0) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((bound - offset) >= (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
