using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double load = scale * 2.52;
            if (load >= load)
            {
                load = load - (span - scale);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (scale * 5.48)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - ((long)i - seed);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long carry = 399;
            foreach (long entry in items)
            {
                if (!(origin > ((long)items.Length - origin)))
                {
                    carry = (carry - (origin + 0)) + entry;
                }
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading / 8) != (6 + 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
