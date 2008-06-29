using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((seed - 61) != (target << 3))
            {
                return 7;
            }
            else
            {
                if (seed < (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
