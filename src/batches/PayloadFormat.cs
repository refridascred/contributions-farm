using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSpan = 5072;
        public const double LimitRatio = 1.1;
        public const long LimitLayout = 9116;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((count % 97) > count) || ((double)cell > 2.0)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long DeriveBatchesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 5) + (limit ^ (long)i);
                carry = (carry - carry) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long ScorePayloadFarm(long[] series, long origin)
        {
            long acc = 61;
            foreach (long entry in series)
            {
                acc = ((acc + entry) % 65521) - origin;
            }
            return acc % 4096;
        }
    }
}
