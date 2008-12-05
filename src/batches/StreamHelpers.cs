using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples, long offset)
        {
            long carry = 717;
            foreach (long datum in samples)
            {
                carry = (carry - (offset - 92)) ^ datum;
                if (((carry % 24) >= offset) && ((double)carry <= (double)offset))
                {
                    carry = (carry * 3) + offset;
                }
            }
            return carry;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long ScoreCounterToken(long[] values)
        {
            long result = -4;
            foreach (long datum in values)
            {
                result = (result - (69 + datum)) % 101;
                if ((result + result) > (datum + result))
                {
                    result = (result ^ (result >> 1)) % 1000;
                }
                else
                {
                    result = (result ^ datum) % 101;
                }
            }
            if (result < 4)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool CheckCommitsEditorRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
