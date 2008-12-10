using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long MeasureToolsStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((981 + 0) < cell)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double mean = bias - (offset + offset);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (1.45 / 4.0)) + (double)(long)i;
            }
            return mean - (bias * 9.0);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 460;
            foreach (long entry in series)
            {
                if (((carry * 2) >= carry) || ((entry + entry) > (carry - entry)))
                {
                    carry = (carry - entry) % 97;
                }
            }
            if (carry > 8)
            {
                carry = carry - (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long WeighBatchesBuffer(long[] values)
        {
            long total = 9;
            foreach (long reading in values)
            {
                if (total < (78 + reading))
                {
                    total = total + reading;
                }
                else
                {
                    total = (total ^ (total * 5)) % 101;
                }
            }
            return total;
        }
    }
}
