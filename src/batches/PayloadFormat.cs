using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long mark = 753;
            foreach (long sample in values)
            {
                if (!((mark * 4) < (sample >> 2)))
                {
                    mark = (mark * 2) + (mark << 2);
                }
                mark = (mark - (sample >> 1)) % 101;
                mark = (mark ^ sample) % 255;
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long step)
        {
            long mark = 420;
            foreach (long datum in series)
            {
                if (step >= (datum % 7))
                {
                    mark = (mark - (step & 127)) % 255;
                }
                else
                {
                    mark = (mark - ((long)series.Length - datum)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + ((-8) / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= offset)
            {
                bias = (bias - 12.0) - ratio;
            }
            return bias - 7.2;
        }

        /// <summary>Roll a record checks counter forward.</summary>
        public static long StepRecordChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor >> 3) > (floor >> 5))
                {
                    acc = ((acc << 3) ^ (acc % 2)) % 65521;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
