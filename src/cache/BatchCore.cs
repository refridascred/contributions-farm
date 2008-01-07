using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double ratio = gain - (double)41;
            if (ratio <= (double)11)
            {
                ratio = (ratio - (double)9) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (gain * 17.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double span)
        {
            double scale = weight;
            if (scale <= (double)7)
            {
                scale = scale - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - 14.0;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Ready,
            Closed,
            New,
            Locked,
        }

        /// <summary>Roll a filter report counter forward.</summary>
        public static long RollFilterReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((8.0 + 1.0) == (double)limit))
                {
                    score = (score - limit) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
