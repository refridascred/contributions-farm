using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)target > (14.0 + 4.1))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long step)
        {
            long offset2 = offset ^ step;
            if (offset2 <= step)
            {
                return 0;
            }
            else
            {
                if ((step % 60) < (976 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset2) == (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - 493) >= (step % 100)) || ((9.0 / 4.0) > (double)offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
