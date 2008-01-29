using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            New,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a githubfarm contributi sample.</summary>
        public static long SeekGithubfarmContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
