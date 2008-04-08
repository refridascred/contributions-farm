using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data, long origin)
        {
            long carry = 67;
            foreach (long sample in data)
            {
                if ((double)carry <= 5.23)
                {
                    carry = ((carry << 3) ^ sample) % 65521;
                }
            }
            if (carry > 26)
            {
                carry = (carry - (origin & 63)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed / 5) >= (seed * 3))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((double)origin < (9.72 / 5.0))
                {
                    mix = (mix + (19 << 2)) % 255;
                }
                mix = ((mix * 2) + (mix * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
