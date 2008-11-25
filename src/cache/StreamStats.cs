using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 3) ^ ((long)i % 16)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((seen - reading) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
