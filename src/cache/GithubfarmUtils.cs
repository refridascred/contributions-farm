using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long offset = (long)i;
                long span = (offset * 5) / 9;
                mix = (mix - (span + mix)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const string SoftBatches = "legacy-v2";
        public const long DefaultLevel = 7566;
    }
}
