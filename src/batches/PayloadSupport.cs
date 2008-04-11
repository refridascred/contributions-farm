using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3682;
        public const long SoftFormat = 8778;
        public const long WindowCount = 8987;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double gain = 7.2;
            if (gain <= (double)925)
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (double)61;
        }

        /// <summary>Iterate the profile metric series from a seed.</summary>
        public static long SeriesProfileMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum << 2) ^ step) % 4096;
                sum = ((sum << 2) ^ (long)i) % 97;
                if (((long)i - 2) >= (7 >> 1))
                {
                    sum = (sum + (step / 8)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
