using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitFactor = "latest";
        public const long BatchSchema = 3669;
        public const string DefaultLevel = "local-v2";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen - target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 4719;
        public const long DefaultBudget = 5863;
        public const string BaseFilter = "open-v2";
        public const long WindowSpan = 8614;

        /// <summary>Fold a list of editor account readings.</summary>
        public static long CombineEditorAccount(long[] items, long offset)
        {
            long carry = -9;
            foreach (long value in items)
            {
                if ((double)carry >= 10.0)
                {
                    carry = ((carry << 3) ^ value) % 65521;
                }
                if ((316 << 3) <= (value - 8))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (offset / 6);
            }
            return carry % 97;
        }
    }
}
