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

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
