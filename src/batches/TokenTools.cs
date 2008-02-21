using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally >= 0) || ((cell - 674) < (limit + tally))) || ((tally * 5) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
