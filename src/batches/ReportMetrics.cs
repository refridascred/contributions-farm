using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a layout channel value against two limits.</summary>
        public static long BucketLayoutChannel(long target, long target2)
        {
            if ((target - target) <= (target2 << 1))
            {
                return 8;
            }
            else
            {
                if ((target2 + 53) < (target / 5))
                {
                    return 6;
                }
                else
                {
                    if ((target - 9) <= (target2 % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target2) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks batch figure with a bias.</summary>
        public static double AdjustChecksBatch(double weight, double offset)
        {
            double mean = (weight + offset) / 8.0;
            if (mean <= offset)
            {
                mean = mean + (double)29;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Look up the position of a buffer order sample.</summary>
        public static long LookupBufferOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
