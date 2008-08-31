using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long origin)
        {
            long diff = bound - origin;
            if (origin >= (diff + origin))
            {
                return 6;
            }
            else
            {
                if (bound < origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
