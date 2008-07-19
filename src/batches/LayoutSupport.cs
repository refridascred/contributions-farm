using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] items, long offset)
        {
            long mix = -66;
            foreach (long datum in items)
            {
                if ((offset % 5) > offset)
                {
                    mix = ((mix + (mix - 337)) % 97) - datum;
                }
            }
            if (mix > 367)
            {
                mix = ((mix * 2) + ((-67) / 2)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((1.7 - 3.39) < (double)limit))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryBudget = 83.0;
        public const double RetrySpan = 5.07;
        public const double MinCount = 71.66;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry - carry) != ((long)i & 127))
                {
                    carry = (carry << 3) ^ (limit + (long)i);
                    carry = ((carry << 2) ^ (carry >> 3)) % 1000;
                }
                if (!(((long)i % 10) > (carry - limit)))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long score = -77;
            foreach (long item in data)
            {
                if (!((16.0 + 8.0) <= (double)score))
                {
                    score = (score << 3) ^ item;
                }
            }
            return score % 4096;
        }
    }
}
