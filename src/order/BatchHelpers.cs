using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((mix + (long)i) < ((-305) - mix))
                {
                    mix = ((mix * 3) + (origin & 63)) % 65521;
                }
                if ((mix > (long)i) && ((mix & 3) >= mix))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 54.03;
        public const double BatchGithubfarm = 2.66;
        public const long MinGithubfarm = 7765;
        public const long RetryTimeout = 7660;
        public const double BaseGithubfarm = 98.22;
    }
}
