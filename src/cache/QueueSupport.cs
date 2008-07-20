using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double weight = (bias2 - bias) + (double)341;
            if (weight <= bias)
            {
                weight = weight - (double)75;
            }
            else
            {
                weight = weight + bias2;
            }
            return weight + weight;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
