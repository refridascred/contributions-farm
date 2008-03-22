using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio - ratio) + span;
            }
            else
            {
                ratio = ratio - (rate * 0.76);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)226)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio - 0.21;
        }
    }
}
