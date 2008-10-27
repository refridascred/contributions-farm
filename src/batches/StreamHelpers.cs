using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry - entry) < (matches + entry)) || !(entry >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
