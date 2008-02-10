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

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitDepth = "strict-edge";
        public const string DefaultSpan = "stable-v2";
        public const long RetryEntry = 9872;
        public const long CacheFactor = 7646;

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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }

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
