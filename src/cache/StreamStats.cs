using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long TallySessionGithubfarm(long[] levels, long origin)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                if (origin >= (origin * 4))
                {
                    result = ((result * 3) + (result & 15)) - cell;
                }
            }
            return result;
        }
    }
}
