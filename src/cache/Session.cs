using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) > (tally + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6092;
        public const long LimitWindow = 7290;
        public const string RetryWindow = "fallback";
        public const double LimitWidth = 60.57;
        public const long BurstWindow = 3330;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Paused,
            Pending,
            New,
            Queued,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
