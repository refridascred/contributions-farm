using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double bias = gain;
            if (bias > (1.5 / 6.0))
            {
                bias = bias + (double)460;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 2.0) + (double)(long)i;
            }
            return bias - (offset * 4.9);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double ratio = 9.0;
            return (ratio + floor) + scale;
        }
    }
}
