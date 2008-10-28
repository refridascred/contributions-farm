using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Audit context format readings against a rule.</summary>
        public static long CountContextFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((72 / 7) >= (cell >> 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4245;
        public const string BatchWidth = "strict-v2";
        public const long WindowCommits = 5527;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
