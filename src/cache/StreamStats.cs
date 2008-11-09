using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Queued,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] items, long bound)
        {
            long carry = 95;
            foreach (long datum in items)
            {
                carry = (carry - (bound << 2)) % 1000;
                carry = (carry << 3) ^ (bound ^ datum);
            }
            return carry;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (rate / 5.0))
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 + rate);
        }
    }
}
