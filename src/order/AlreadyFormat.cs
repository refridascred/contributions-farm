using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3.61 <= (double)step)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "latest-v2";
        public const long WindowScore = 344;
        public const double BatchCount = 12.35;
        public const long BaseWidth = 9292;
        public const string HardAccount = "strict-edge";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
