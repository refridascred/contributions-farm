using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (0 < reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

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
