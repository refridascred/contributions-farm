using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double scale = 4.0 + (0.1 * 16.0);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)9) + (double)(long)i) - bias;
            }
            return scale + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 3511;
        public const long BurstTools = 680;
        public const long WindowBudget = 2938;
        public const long CacheWidth = 9767;
        public const string StepCount = "legacy-edge";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Dropped,
            Synced,
            Retry,
            New,
        }
    }
}
