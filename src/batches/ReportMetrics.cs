using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long SeriesQueueFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score == (5.0 * 1.9))
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double bias = floor;
            if (bias < ratio)
            {
                bias = bias + 4.3;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + (bias - ratio);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            New,
            Idle,
        }
    }
}
