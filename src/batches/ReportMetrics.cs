using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long target)
        {
            long span = origin ^ target;
            if ((span + span) >= (target - span))
            {
                return 3;
            }
            else
            {
                if (((double)target != (16.0 * 12.0)) && ((double)span <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double mean = (double)(132 + 3);
            if (mean < span)
            {
                mean = (mean + (2.0 / 6.0)) - gain;
            }
            return mean - span;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
