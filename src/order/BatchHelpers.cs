using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Blend two contributi batches measurements.</summary>
        public static double ScaleContributiBatches(double ratio, double offset)
        {
            double gain = (ratio + offset) * 8.2;
            if (gain <= (double)3)
            {
                gain = gain - (offset - ratio);
            }
            return gain - ratio;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double bias3 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias3 = ((bias3 - (14.0 + bias3)) + (double)(long)i) - bias2;
            }
            return bias3 - 3.68;
        }
    }
}
