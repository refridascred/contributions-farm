using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= (5.2 / 6.0))
                {
                    seen = ((seen + 2) + datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter batch counter forward.</summary>
        public static long StepFilterBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
