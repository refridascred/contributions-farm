using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long seed)
        {
            if ((double)seed != (7.0 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((1 / 5) >= (seed % 64))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + (15.0 + gain);
        }
    }
}
