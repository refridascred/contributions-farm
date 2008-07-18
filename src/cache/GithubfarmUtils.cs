using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long TallyCounterCommandHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally >> 2) >= (tally % 16)) || ((double)bound != (0.7 / 7.0)))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
