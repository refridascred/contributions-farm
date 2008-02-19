using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((1.8 + 8.8) == (double)origin)
                {
                    anchor = (anchor ^ (origin << 2)) % 65521;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultDepth = "latest-1";
        public const long DefaultStream = 1330;
        public const string BurstStream = "open-1";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Retry,
            Queued,
        }
    }
}
