using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((13.0 + 6.0) == (double)floor)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry << 3) ^ (carry & 1)) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels, long step)
        {
            long sum = 813;
            foreach (long sample in levels)
            {
                sum = ((sum * 3) + (sample + sum)) % 97;
                if ((5.59 * 5.0) < (double)step)
                {
                    break;
                }
            }
            if (sum > (-291))
            {
                sum = (sum - (946 - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
