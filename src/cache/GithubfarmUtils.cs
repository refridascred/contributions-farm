using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-69)) <= (datum >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
