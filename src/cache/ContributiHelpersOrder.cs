using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 3) <= (entry % 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                acc = (acc << 3) ^ (acc + item);
            }
            return acc;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
