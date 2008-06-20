using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset + offset2) <= (offset & 63))
            {
                return 6;
            }
            else
            {
                if (!((offset2 + offset3) < 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a context editor figure with a bias.</summary>
        public static double ScaleContextEditor(double ratio, double bias)
        {
            double weight = (double)(709 % 2);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) + ratio;
            }
            return weight + (double)0;
        }
    }
}
