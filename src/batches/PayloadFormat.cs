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

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
