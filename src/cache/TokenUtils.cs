using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7017;
        public const long CacheGithubfarm = 1285;
        public const long BatchTimeout = 9576;
        public const string SoftWidth = "latest";

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool ValidatePayloadFormatRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
