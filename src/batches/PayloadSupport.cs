using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double scale = 1.3;
            if (scale >= (double)7)
            {
                scale = (scale + bias) + weight;
            }
            else
            {
                scale = scale - (scale + scale);
            }
            return scale - (double)1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 206;
            foreach (long reading in series)
            {
                sum = ((sum - (sum * 2)) % 255) ^ reading;
                if ((sum >> 3) < sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Pending,
            Synced,
        }
    }
}
