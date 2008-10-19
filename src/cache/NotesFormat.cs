using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two counter context measurements.</summary>
        public static double BlendCounterContext(double weight, double bias)
        {
            double ratio = (weight * 0.33) / 6.0;
            if (ratio < (3.96 * 19.0))
            {
                ratio = (ratio + (double)25) + bias;
            }
            else
            {
                ratio = ratio - 2.56;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (3.44 * 2.3)) - (double)(long)i;
            }
            return ratio + (ratio * 4.1);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((84 + entry) <= (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer payload sample.</summary>
        public static long SeekBufferPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
