using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 - rate2) + (double)(long)i) - span;
            }
            return rate2 + 1.3;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Done,
            Locked,
            Queued,
        }
    }
}
