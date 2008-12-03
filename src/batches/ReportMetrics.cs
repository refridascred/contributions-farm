using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
