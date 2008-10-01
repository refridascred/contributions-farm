using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.23;
        public const string StepStats = "stable";
        public const long RetryLevel = 5034;
        public const long IdleStats = 6130;
        public const string CacheStats = "alpha-v2";

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
