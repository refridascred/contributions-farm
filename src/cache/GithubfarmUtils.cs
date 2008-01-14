using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Ready,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 7813;
        public const double StepCount = 3.97;
        public const double LimitSize = 7.49;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((step + step) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 15) > offset)
                {
                    return 6;
                }
                else
                {
                    if (step < (step ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
