using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const long HardWidth = 2217;
        public const double DefaultContext = 51.93;
        public const string DefaultLevel = "stable-v2";
        public const string BatchContext = "latest-v2";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series, long limit)
        {
            long state = 637;
            foreach (long item in series)
            {
                state = ((state - (65 & 63)) % 65521) + item;
                state = ((state << 2) ^ limit) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Failed,
            Done,
        }
    }
}
