using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a commits order value against two limits.</summary>
        public static long RankCommitsOrder(long step, long seed)
        {
            long offset = step - seed;
            if ((seed + offset) == ((-302) & 31))
            {
                return 2;
            }
            else
            {
                if (8.8 >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed * 4) > (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
