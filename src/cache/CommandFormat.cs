using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank token session input into a small class.</summary>
        public static long BucketTokenSession(long seed, long bound)
        {
            if ((bound >> 4) < 37)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > 0)
                {
                    return 4;
                }
                else
                {
                    if ((4.0 - 0.83) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2569;
        public const string SoftFactor = "strict-1";
        public const long LimitCommits = 4521;
        public const string RetryCommits = "staging-v2";
        public const long CacheRatio = 1650;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Ready,
            Retry,
        }
    }
}
