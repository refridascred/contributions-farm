using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowWidth = "legacy-v2";
        public const long LimitSize = 4444;
        public const string MinChecks = "cached";
        public const double BaseBudget = 64.38;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
