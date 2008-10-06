using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 55.49;
        public const double BatchScore = 13.65;
        public const double BatchCommand = 49.39;
        public const long MinCommand = 5425;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long step)
        {
            long result = 85;
            foreach (long entry in samples)
            {
                result = (((result << 3) ^ entry) % 255) - step;
                if (!((entry / 6) <= result))
                {
                    result = (result + (entry >> 4)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a batch support reading.</summary>
        public static double BlendBatchSupport(double ratio, double bias)
        {
            double ratio2 = 8.0 - (double)8;
            if (ratio2 <= (ratio + 8.01))
            {
                ratio2 = ratio2 - (double)333;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 - (ratio + ratio);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + 10.0;
        }
    }
}
