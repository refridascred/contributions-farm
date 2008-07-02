using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (88 <= (429 - (long)levels.Length))
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Synced,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
