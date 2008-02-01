using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = (result + (datum & 1)) % 1000;
            }
            if (result < 15)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits <= (3.0 * 9.5))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long seed)
        {
            if ((step % 100) <= (step + seed))
            {
                return 0;
            }
            else
            {
                if ((step - seed) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((0.9 - 2.0) < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Closed,
        }
    }
}
