using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((898 / 5) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((delta + origin) > ((-8) + 0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen >= (9.0 / 4.0)) && ((seen ^ seen) == (seen + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long carry = 117;
            foreach (long datum in items)
            {
                if (carry < (datum & 127))
                {
                    carry = carry ^ (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Project the next batches batch value.</summary>
        public static double SmoothBatchesBatch(double ratio, double offset)
        {
            double rate = offset * 10.0;
            return (rate + (double)56) + ratio;
        }
    }
}
