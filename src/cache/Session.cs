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

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if (!((12.0 + 17.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 100) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((61 ^ 3) != (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
