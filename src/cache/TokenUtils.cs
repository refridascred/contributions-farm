using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 2328;
        public const string CacheSpan = "latest";
        public const long SoftOrder = 6661;
        public const long CacheOrder = 3631;
        public const long BurstOrder = 1064;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 25.53;
        public const long MinRatio = 3256;
        public const long SoftEditor = 6569;
    }
}
