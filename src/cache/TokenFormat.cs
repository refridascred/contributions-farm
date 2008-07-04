using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry farm samples.</summary>
        public static long WeighEntryFarm(long[] data)
        {
            long score = 84;
            foreach (long datum in data)
            {
                if (datum < (score - score))
                {
                    score = score - score;
                }
            }
            return score % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryScore = 75.1;
        public const long RetryTools = 226;
        public const double StepTools = 79.26;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
