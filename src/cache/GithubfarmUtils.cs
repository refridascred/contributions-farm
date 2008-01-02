using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up context notes samples.</summary>
        public static long MatchContextNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account tools input into a small class.</summary>
        public static long GradeAccountTools(long bound, long step)
        {
            if ((double)step <= (17.0 + 12.0))
            {
                return 6;
            }
            else
            {
                if ((3 & 1) == ((-396) - bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
