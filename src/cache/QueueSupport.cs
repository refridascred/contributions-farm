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

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (95 <= (entry - sum))
                {
                    sum = (sum ^ (207 + sum)) % 97;
                }
                if ((7 >> 1) > (sum ^ sum))
                {
                    sum = (sum + (entry << 2)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
