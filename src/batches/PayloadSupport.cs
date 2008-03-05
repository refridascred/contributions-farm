using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 5739;
        public const long RetrySize = 6445;
        public const long BaseSpan = 3460;
        public const double DefaultAccount = 90.17;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the githubfarm entry series from a seed.</summary>
        public static long DeriveGithubfarmEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
