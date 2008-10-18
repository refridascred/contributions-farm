using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((seen - item) >= item) || ((item ^ seen) > (item + item))) && ((double)seen <= 12.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double bias)
        {
            double rate = 5.0 / 3.0;
            return ((rate - rate) + ratio) + bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long carry = 836;
            foreach (long value in items)
            {
                if (31 < (value >> 5))
                {
                    carry = carry + (carry & 127);
                }
                if (value <= carry)
                {
                    carry = carry - (862 + 795);
                }
            }
            if (carry > 87)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Closed,
            Dropped,
            Queued,
        }
    }
}
