using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next stream profile value from a seed.</summary>
        public static long DeriveStreamProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((mark + mark) >= (mark >> 1)))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading ^ limit) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
