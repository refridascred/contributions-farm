using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Active,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardLevel = 2188;
        public const string MinRatio = "local-1";
        public const long IdleTimeout = 3985;
        public const double DefaultCommits = 64.62;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
