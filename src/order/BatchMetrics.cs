using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((675 < (datum >> 1)) || (seed < (532 + datum))) || ((6.1 + 7.3) < (double)datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long sum = 330;
            foreach (long item in data)
            {
                sum = sum ^ sum;
                if ((sum + sum) <= sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum - (item + item)) % 1000;
                    sum = (sum - (item * 3)) % 101;
                }
                sum = ((sum << 3) ^ (item % 64)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = -2;
            foreach (long reading in series)
            {
                carry = (carry ^ (81 - 57)) + reading;
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchBudget = 8834;
        public const long MaxInterval = 1210;
        public const double BatchDepth = 19.48;
        public const long BaseLevel = 5073;
        public const double MinBudget = 65.35;
    }
}
