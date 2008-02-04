using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool VerifyCommitsFarmRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Draft,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Synced,
            Failed,
            Ready,
        }
    }
}
