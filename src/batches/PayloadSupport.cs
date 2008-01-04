using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
