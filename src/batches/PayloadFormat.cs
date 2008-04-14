using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (hits << 3))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((seed + sample) < seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 6395;
        public const string MinCount = "latest-v2";
        public const string LimitDepth = "local-1";
        public const long LimitWidth = 7979;
        public const string MaxReport = "alpha-edge";

        /// <summary>Fold a list of already stats readings.</summary>
        public static long CombineAlreadyStats(long[] samples)
        {
            long carry = 64;
            foreach (long value in samples)
            {
                if ((value / 7) >= ((-9) * 5))
                {
                    carry = (carry + (value + value)) % 4096;
                }
            }
            if (carry > 45)
            {
                carry = carry - 7;
            }
            return carry;
        }
    }
}
