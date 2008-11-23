using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)origin < (8.7 - 9.27))
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + origin) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long mix = 813;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + reading) % 4096;
            }
            if (mix > 29)
            {
                mix = ((mix * 3) + (mix << 2)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 63) < (reading + 71))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
