using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long ClassifyGithubfarmToken(long bound, long bound2)
        {
            if ((double)bound > 7.2)
            {
                return 7;
            }
            else
            {
                if ((bound2 - 94) != (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 * 2) >= (59 + 78))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Done,
            Stale,
            New,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Active,
            Stale,
        }
    }
}
