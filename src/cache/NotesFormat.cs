using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats cluster reading.</summary>
        public static double BlendStatsCluster(double bias, double bias2)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean + (bias * 6.96);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias2 + bias)) - (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long limit)
        {
            long lane = offset - limit;
            if (((13.0 * 4.0) != (double)lane) || ((lane + lane) < (offset - lane)))
            {
                return 5;
            }
            else
            {
                if ((offset % 100) > (lane << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
