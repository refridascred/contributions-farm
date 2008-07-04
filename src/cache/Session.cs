using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first githubfarm buffer entry that matches the target.</summary>
        public static long SeekGithubfarmBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
