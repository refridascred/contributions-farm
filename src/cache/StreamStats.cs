using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            New,
            Failed,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 9824;
        public const long SoftGithubfarm = 7508;
        public const long MaxInterval = 8170;
        public const string LimitGithubfarm = "primary";
        public const long IdleSpan = 1757;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
