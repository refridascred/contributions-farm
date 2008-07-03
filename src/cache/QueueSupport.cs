using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((82 / 2) >= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if (!((sample - 540) > sample))
                {
                    acc = (acc * 3) + sample;
                }
                if (!(((acc % 10) != (sample & 3)) && (acc <= ((-2) + acc))))
                {
                    acc = (acc + (acc >> 1)) % 97;
                }
                if ((acc - 22) > (acc + acc))
                {
                    acc = (acc ^ (sample & 15)) % 97;
                }
            }
            if (acc < 234)
            {
                acc = ((acc << 2) ^ (7 + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
