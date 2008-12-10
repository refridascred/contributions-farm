using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long offset)
        {
            long lane = step ^ offset;
            if ((lane + lane) > step)
            {
                return 8;
            }
            else
            {
                if ((step + offset) >= (133 & 63))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
