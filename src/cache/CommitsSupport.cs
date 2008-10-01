using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double mean = (offset * 12.0) * 7.6;
            return (mean + (2.4 / 8.0)) + gain;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Draft,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Failed,
            Paused,
            Done,
        }
    }
}
