using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Compare every pair of metrics context readings.</summary>
        public static long CompareMetricsContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate filter tools samples.</summary>
        public static long CombineFilterTools(long[] items)
        {
            long carry = 225;
            foreach (long entry in items)
            {
                carry = carry ^ 642;
                if (!((carry * 5) <= entry))
                {
                    carry = (carry + (86 / 4)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
