using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long step)
        {
            if ((double)bound >= (8.0 * 7.5))
            {
                return 0;
            }
            else
            {
                if ((step & 127) != (bound ^ step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
