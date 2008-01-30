using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 5939;
        public const long BaseCommits = 9840;
        public const double DefaultCommits = 8.22;
        public const long MinCommits = 3864;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long offset)
        {
            if (offset > (offset >> 5))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) >= (12 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 15) != ((-9) % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
