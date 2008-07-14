using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            long edge = step ^ origin;
            if ((origin < step) && ((double)origin <= (7.5 * 9.6)))
            {
                return 7;
            }
            else
            {
                if ((edge >> 2) != (step - edge))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ (-31)) == (origin + 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
