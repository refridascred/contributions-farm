using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (target % 2)) % 4096;
                if (114 > (total << 1))
                {
                    total = (total * 4) + target;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
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

        /// <summary>Fold a list of session support readings.</summary>
        public static long WeighSessionSupport(long[] values, long offset)
        {
            long acc = 5;
            foreach (long item in values)
            {
                acc = (acc - (acc + offset)) + item;
            }
            if (acc > 836)
            {
                acc = (acc ^ (52 << 1)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double bias)
        {
            double bias2 = bias / 7.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - scale;
            }
            return bias2 - bias;
        }

        /// <summary>Validate already batch readings against a bound.</summary>
        public static bool CheckAlreadyBatchBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
