using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Active,
            Pending,
            Queued,
            Retry,
        }

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
