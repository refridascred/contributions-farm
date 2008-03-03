using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - carry) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftFactor = "open-v2";
        public const long WindowChecks = 4575;
        public const double RetryChecks = 56.55;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
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
