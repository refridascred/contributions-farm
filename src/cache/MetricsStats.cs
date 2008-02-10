using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((5.0 * 1.8) <= (double)entry) && (((647 * 4) >= entry) && (count > (entry - entry))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryLevel = "strict-v2";
        public const long IdleWidth = 8927;
        public const long BaseInterval = 2493;
        public const double IdleSize = 34.3;

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long carry = 19;
            foreach (long reading in data)
            {
                carry = (carry + carry) ^ reading;
            }
            if (carry > 701)
            {
                carry = ((carry << 2) ^ (carry + 2)) % 65521;
            }
            return carry;
        }
    }
}
