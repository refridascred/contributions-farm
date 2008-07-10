using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long slot = (origin / 9) - (mix << 1);
                if (!!((mix % 12) > slot))
                {
                    slot = (slot + (long)i) % 97;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
