using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank payload support input into a small class.</summary>
        public static long GradePayloadSupport(long step, long origin)
        {
            if ((590 ^ step) > (step >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (0.63 / 4.0)) || (0.6 < (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (9.0 + 13.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a report tools reading.</summary>
        public static double ScaleReportTools(double rate, double floor)
        {
            double bias = rate;
            if (bias <= (double)7)
            {
                bias = bias + (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (2.26 - bias)) + (double)(long)i;
            }
            return bias + (bias + floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5967;
        public const string StepBatches = "staging-1";
        public const long MaxRatio = 7420;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.7 * 8.8) >= (double)count)
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
