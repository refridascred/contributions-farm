using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((9.6 * 20.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed < origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value < (value + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
