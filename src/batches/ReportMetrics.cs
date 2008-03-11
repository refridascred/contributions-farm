using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values)
        {
            long score = 52;
            foreach (long item in values)
            {
                if (score >= (score / 4))
                {
                    score = (score - score) + item;
                }
            }
            if (score < 465)
            {
                score = (score - score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > offset)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight + (double)551;
            }
            return weight + (ratio - 2.6);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long offset)
        {
            if (((floor << 3) < (408 + floor)) && ((offset + offset) > (floor + floor)))
            {
                return 4;
            }
            else
            {
                if ((3.6 < (double)offset) && ((double)offset >= (1.7 / 9.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - 4) > (offset + (-490)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > ((-1) % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
