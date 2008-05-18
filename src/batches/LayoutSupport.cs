using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Retry,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 5349;
        public const long MinSpan = 3775;
        public const string BaseWindow = "standard-edge";
        public const long MinWindow = 4194;
        public const long DefaultWindow = 4894;
    }
}
