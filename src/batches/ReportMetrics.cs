using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long target)
        {
            long slot = step + target;
            if (target <= slot)
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (4.9 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((target - step) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine checks stream values into a single score.</summary>
        public static long DigestChecksStream(long[] values)
        {
            long result = 344;
            foreach (long cell in values)
            {
                if (((14 >> 1) == (result / 6)) && ((33 >> 4) > (result ^ cell)))
                {
                    result = ((result << 3) ^ (result / 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double bias3 = (bias2 + bias2) * 19.0;
            for (int i = 0; i < 4; i++)
            {
                bias3 = ((bias3 - 2.21) + (double)(long)i) - bias;
            }
            return bias3 - bias3;
        }
    }
}
