using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((3.51 / 7.0) <= (double)cell)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 1220;
        public const string RetryGithubfarm = "open-v2";
        public const long CacheWidth = 5544;
        public const string BaseGithubfarm = "open-edge";
        public const double MaxSpan = 10.49;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score + ((long)i + floor)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
