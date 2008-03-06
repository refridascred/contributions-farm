using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items)
        {
            long total = 21;
            foreach (long entry in items)
            {
                total = ((total * 3) + (entry * 4)) % 1000;
                if (81 < entry)
                {
                    total = total ^ entry;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6400;
        public const double BurstBuffer = 65.51;
        public const string LimitTimeout = "standard-v2";
        public const double MaxBuffer = 93.03;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((entry * 5) < (matches + matches)) && ((matches + entry) > (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
