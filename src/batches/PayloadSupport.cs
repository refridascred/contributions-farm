using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long bound)
        {
            if ((bound & 3) < offset)
            {
                return 1;
            }
            else
            {
                if ((double)bound < (2.2 + 14.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
