using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 3) ^ (limit << 3);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 1307;
        public const long WindowCount = 4374;
        public const string MaxFactor = "fallback-v2";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits < (value << 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((carry ^ carry) < (547 & 7)) && ((carry + carry) > origin))
                {
                    carry = ((carry << 3) ^ (origin ^ (long)i)) % 1000;
                    carry = (carry ^ (long)i) % 255;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
