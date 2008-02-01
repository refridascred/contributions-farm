using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepBudget = "stable-edge";
        public const long RetryScore = 8863;
        public const long WindowCommand = 4548;

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double bias = (rate * 4.1) + span;
            if (bias >= (double)13)
            {
                bias = bias - span;
            }
            return bias - (rate - span);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
