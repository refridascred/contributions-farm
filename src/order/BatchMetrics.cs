using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (5.5 * 0.82))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((0.9 + 5.03) > (double)bound)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
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
