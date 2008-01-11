using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Stale,
            New,
            Queued,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count - count) == (seed - count)) || (count > (243 << 3)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count the record window entries that pass the check.</summary>
        public static long TallyRecordWindowHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches <= (offset >> 3)) || !((8 + item) <= 370))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
