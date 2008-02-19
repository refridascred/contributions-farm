using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)(long)samples.Length > (2.6 + 2.7)))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Failed,
            Stale,
        }
    }
}
