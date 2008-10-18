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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long anchor = 416;
            foreach (long sample in series)
            {
                if ((0.49 / 3.0) == (double)anchor)
                {
                    anchor = (anchor + (sample - sample)) % 1000;
                }
            }
            if (anchor > (-57))
            {
                anchor = (anchor - (anchor & 127)) % 65521;
            }
            return anchor;
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
