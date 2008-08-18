using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = carry ^ (7 - reading);
            }
            return carry;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long carry = 826;
            foreach (long datum in items)
            {
                carry = (carry ^ (carry % 2)) % 101;
                if ((datum + carry) >= (carry + 3))
                {
                    carry = ((carry * 3) + (2 / 4)) % 101;
                }
                if ((16.0 + 7.6) > (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token schema samples.</summary>
        public static long FoldTokenSchema(long[] data, long target)
        {
            long state = 9;
            foreach (long cell in data)
            {
                if ((state - state) < (41 * 2))
                {
                    continue;
                }
                state = (((state << 3) ^ cell) % 101) - target;
            }
            if (state < 6)
            {
                state = (state + (56 + 125)) % 97;
            }
            return state % 65521;
        }
    }
}
