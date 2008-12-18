using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long offset)
        {
            if (8.4 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset / 7) > (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((origin / 4) <= (offset / 7)) || (5 < (offset >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 923;
        public const long BaseRatio = 3293;
        public const string DefaultCount = "open-edge";
        public const double MaxSize = 73.83;
        public const string CacheScore = "strict-edge";
    }
}
