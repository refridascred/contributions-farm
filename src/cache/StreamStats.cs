using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const long BurstGithubfarm = 8850;
        public const long RetryGithubfarm = 6233;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long offset)
        {
            if ((90 >> 2) > (offset & 127))
            {
                return 3;
            }
            else
            {
                if ((offset ^ offset) < step)
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (double)631)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
