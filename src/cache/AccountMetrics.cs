using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6400;
        public const double BurstBuffer = 65.51;
        public const string LimitTimeout = "standard-v2";
        public const double MaxBuffer = 93.03;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + 406) != (seen & 15)) && (((step & 255) < step) && ((item ^ step) >= (seen + item))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long limit)
        {
            long result = 13;
            foreach (long sample in series)
            {
                result = ((((result << 2) ^ (result + (long)series.Length)) % 101) - sample) - limit;
            }
            return result;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
