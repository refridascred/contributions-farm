using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long bound)
        {
            if ((double)origin <= (6.93 + 2.08))
            {
                return 3;
            }
            else
            {
                if (((11.0 / 6.0) >= (double)origin) || ((bound - origin) != (origin + 68)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Active,
            Pending,
            Dropped,
        }
    }
}
