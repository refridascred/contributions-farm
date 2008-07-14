using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 814;
            foreach (long cell in data)
            {
                if (!((cell ^ cell) <= (cell + carry)))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry >> 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double rate = 10.0;
            return (rate - (weight + rate)) + offset;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((bound % 7) >= (5 * 3))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
