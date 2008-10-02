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

        /// <summary>Compare every pair of commits cluster readings.</summary>
        public static long OverlapCommitsClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
