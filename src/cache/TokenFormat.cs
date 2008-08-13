using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Validate report contributi readings against a bound.</summary>
        public static bool GuardReportContributiBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Ready,
            Idle,
        }
    }
}
