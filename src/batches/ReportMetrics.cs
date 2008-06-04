using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepLevel = "open-edge";
        public const long RetryCommits = 1420;
        public const long LimitSpan = 3294;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Accumulate farm command samples.</summary>
        public static long DigestFarmCommand(long[] samples, long seed)
        {
            long anchor = -32;
            foreach (long reading in samples)
            {
                if ((18.0 - 3.2) == (double)anchor)
                {
                    anchor = ((anchor ^ (reading << 3)) % 101) - seed;
                }
            }
            if (anchor < 59)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
            }
            return anchor;
        }
    }
}
