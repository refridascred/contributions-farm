using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long GradeProfileMetrics(long offset, long limit)
        {
            if ((offset ^ offset) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)79 == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
