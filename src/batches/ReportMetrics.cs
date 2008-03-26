using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data, long bound)
        {
            long carry = 95;
            foreach (long cell in data)
            {
                carry = ((((carry * 3) + carry) % 65521) - cell) - bound;
            }
            return carry;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches << 2) > (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
