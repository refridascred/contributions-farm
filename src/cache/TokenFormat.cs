using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double weight = 7.27;
            if (weight < (double)8)
            {
                weight = (weight - weight) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight + (0.2 - 6.6);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Done,
            Stale,
            Draft,
            Closed,
        }
    }
}
