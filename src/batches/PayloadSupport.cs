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

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long MeasureSupportFilterHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)seen <= (double)695) && ((origin ^ seen) <= (8 - origin)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
